using SharpReact.MetaDataGenerator.Settings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using static System.Console;

namespace SharpReact.MetaDataGenerator
{
    class Program
    {
        static int Main(string[] args)
        {
            string configFile = args.Length > 0 ? args[0] : "config.yaml";
            if (!File.Exists(configFile))
            {
                WriteLine($"Can't find config file {configFile}");
                return -1;
            }
            var config = ReadSettings(configFile);
            WriteLine($"Config file read, processing {config.Assemblies?.Count} assemblies");
            try
            {
                Process(config);
            }
            catch (Exception ex)
            {
                WriteLine($"Failed to process assemblies: {ex.Message}");
            }
#if DEBUG
            WriteLine("Done");
            //ReadLine();
#endif
            return 0;
        }

        static void Process(AppSettings config)
        {
            var rootType = GetRootType(config);
            if (rootType == null)
            {
                throw new Exception($"Failed to find root type {config.RootType.Name} in assembly {config.RootType.AssemblyPath}");
            }
            DeleteFiles(config.Properties, config.OutputDirectory);
            DeleteFiles(config.Components, config.OutputDirectory);
            CreateProperties(rootType, isRoot: true, config.OutputDirectory, config.Namespace, config.Properties);
            CreateComponents(rootType, isRoot: true, config.OutputDirectory, config.Namespace, config.Components, config.Properties);
            foreach (var assemblySettings in config.Assemblies)
            {
                WriteLine($"{assemblySettings.Path}");
                ProcessAssembly(config, rootType, assemblySettings);
            }
        }

        static void DeleteFiles(SectionSettings settings, string outputDirectory)
        {
            string path = Path.Combine(outputDirectory, settings.Path);
            foreach (string file in Directory.GetFiles(path))
            {
                string fileName = Path.GetFileName(file);
                if (settings.FixedFiles == null || Array.IndexOf(settings.FixedFiles, fileName) < 0)
                {
                    File.Delete(file);
                }
            }
        }

        static void ProcessAssembly(AppSettings config, Type rootType, AssemblySettings settings)
        {
            string assemblyPath = GetAssemblyPath(config.RootAssemblyPath, settings.Path);
            var assembly = LoadAssembly(assemblyPath);
            var types = from t in assembly.GetTypes()
                        where t.IsPublic && t.IsSubclassOf(rootType)
                        select t;
            foreach (var type in types)
            {
                ProcessType(config, type);
            }
        }

        static void ProcessType(AppSettings config, Type type)
        {
            WriteLine($"\t{type.Name}");
            CreateProperties(type, isRoot: false, config.OutputDirectory, config.Namespace, config.Properties);
            CreateComponents(type, isRoot: false, config.OutputDirectory, config.Namespace, config.Components, config.Properties);
        }
        static string GetTypeName(Type type)
        {
            if (type.IsGenericType)
            {
                return $"{GetPureName(type.Name)}<{string.Join(",", type.GetTypeInfo().GenericTypeParameters.Select(a => a.Name))}>";
            }
            else
            {
                return type.Name;
            }
        }
        static string GetTypeFullName(Type type)
        {
            if (type.IsGenericType)
            {
                return $"{GetPureName(type.FullName)}<{string.Join(",", type.GetTypeInfo().GenericTypeParameters.Select(a => a.Name))}>";
            }
            else
            {
                return type.FullName;
            }
        }
        static string ToCamelCase(string text) => char.ToLower(text[0]) + text.Substring(1);
        static bool IsListProperty (Type type) => type.FullName == "System.Windows.Controls.UIElementCollection";
        static PropertyInfo[] GetTypeProperties(Type type)
        {
            var properties = from p in type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                             where IsListProperty(p.PropertyType)
                                || p.SetMethod != null && p.SetMethod.IsPublic && p.GetMethod != null
                             where !p.GetCustomAttributesData().Any(a => a.AttributeType == typeof(ObsoleteAttribute))
                             select p;
            return properties.ToArray();
        }
        static System.Reflection.EventInfo[] GetTypeEvents(Type type)
        {
            var events = from e in type.GetEvents(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                         where !e.GetCustomAttributesData().Any(a => a.AttributeType == typeof(ObsoleteAttribute))
                         select e;
            return events.ToArray();
        }
        static bool HasChildrenContainerProperty(string childrenContainerName, in PropertyInfo[] properties)
        {
            return properties.Any(p => string.Equals(p.Name, childrenContainerName));
        }
        static bool HasContainerProperty(string containerName, in PropertyInfo[] properties)
        {
            return properties.Any(p => string.Equals(p.Name, containerName));
        }
        static void CreateProperties(Type type, bool isRoot, string outputDirectory, string rootNamespace, PropsSettings settings)
        { 
            string path = Path.Combine(outputDirectory, settings.Path, $"{type.Name}.cs");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            string superClass = isRoot ? "Core.Properties.SharpNativeProp" : type.BaseType.Name;
            var properties = GetTypeProperties(type);
            var events = GetTypeEvents(type);
            var lastProperty = properties.LastOrDefault();
            var sb = new StringBuilder();
            string abstractType = IsTypeCreatable(type) ? "": " abstract";
            bool isContainer = HasContainerProperty(settings.ContainerPropertyName, properties);
            bool isChildrenContainer = HasChildrenContainerProperty(settings.ChildrenContainerPropertyName, properties);
            string implementedInterfaces = "";
            if (isContainer)
            {
                implementedInterfaces += ", IContainer";
            }
            if (isChildrenContainer)
            {
                implementedInterfaces += ", IChildrenContainer";
            }
            if (settings.Namespaces != null)
            {
                foreach (string ns in settings.Namespaces)
                {
                    sb.AppendLine($"using {ns};");
                }
            }
            sb.AppendLine();
            sb.AppendLine($"namespace {rootNamespace}.Props");
            sb.AppendLine("{");
            sb.AppendLine($"\tpublic{abstractType} class {GetTypeName(type)}: {superClass}{implementedInterfaces}");
            sb.AppendLine("\t{");
            foreach (var p in properties)
            {
                if (string.Equals(p.Name, settings.ContainerPropertyName, StringComparison.Ordinal))
                {
                    sb.AppendLine($"\t\tpublic ISharpProp {p.Name} {{ get; set; }}");
                    if (!string.Equals(p.Name, "Content", StringComparison.Ordinal))
                    {
                        sb.AppendLine($"\t\tISharpProp IContent.Content => {p.Name}");
                    }
                }
                else if (string.Equals(p.Name, settings.ChildrenContainerPropertyName, StringComparison.Ordinal))
                {
                    sb.AppendLine($"\t\tpublic List<ISharpProp> {p.Name} {{ get; set; }} = new List<ISharpProp>();");
                    sb.AppendLine($"\t\tIList<ISharpProp> IChildrenContainer.Children => {p.Name};");
                }
                else if (IsListProperty(p.PropertyType))
                {
                    sb.AppendLine($"\t\tpublic System.Collections.Generic.List<ISharpProp> {p.Name} {{ get; set; }} = new System.Collections.Generic.List<ISharpProp>();");
                }
                else
                {
                    sb.AppendLine($"\t\tpublic ReactParam<{GetPropertyType(p.PropertyType)}>? {p.Name} {{ get; set; }}");
                }
            }
            foreach (var e in events)
            {
                sb.AppendLine($"\t\tpublic {GetEventTypeFullName(e.EventHandlerType)} {e.Name} {{ get; set; }}");
            }
            sb.AppendLine("\t\tprotected override ISharpStatefulComponent CreateComponent()");
            sb.AppendLine("\t\t{");
            if (IsTypeCreatable(type))
            {
                string tElement = type.IsSealed ? "" : ", " + GetTypeFullName(type);
                string additionalTypeParameters = type.IsGenericType ? string.Join(",", type.GetTypeInfo().GenericTypeParameters.Select(a => a.Name)) + ", " : "";
                sb.AppendLine($"\t\t\treturn new Components.{GetPureName(type.Name)}<{additionalTypeParameters}{GetTypeName(type)}{tElement}>();");
            }
            else
            {
                sb.AppendLine("\t\t\tthrow new System.NotImplementedException();");
            }
            sb.AppendLine("\t\t}");
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            File.WriteAllText(path, sb.ToString());
        }
        static bool IsTypeCreatable(Type type)
        {
            return !type.IsAbstract && type.IsPublic && type.GetConstructor(Type.EmptyTypes) != null;
        }
        static string GetPropertyType(Type type)
        {
            if (type.IsGenericType)
            {
                return $"{GetPureName(type.FullName)}<{type.GenericTypeArguments[0].FullName}>";
            }
            else
            {
                return type.FullName;
            }
        }
        static string GetEventTypeFullName(Type type)
        {
            string name;
            if (type.IsGenericType)
            {
                name = $"{GetPureName(type.Name)}<{string.Join(",", type.GenericTypeArguments.Select(a => GetGenericEventTypeParameter(a)))}>";
            }
            else
            {
                name = type.Name;
            }
            return $"{type.Namespace}.{name}";
        }
        static string GetGenericEventTypeParameter(Type argument)
        {
            if (argument.IsGenericParameter)
            {
                return argument.Name;
            }
            return $"{argument.Namespace}.{argument.Name}";
        }
        static string GetPureName(string genericName)
        {
            int last = genericName.IndexOf('`');
            if (last >= 0)
            {
                return genericName.Substring(0, last);
            }
            else
            {
                return genericName;
            }
        }
        static void CreateComponents(Type type, bool isRoot, string outputDirectory, string rootNamespace, ComponentSettings settings, PropsSettings propSettings)
        {
            string path = Path.Combine(outputDirectory, settings.Path, $"{type.Name}.cs");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            string tElement = type.IsSealed ? GetTypeFullName(type) : "TElement";
            string superClass = isRoot 
                ? "SharpWpfComponent<TProps, object, TElement>" 
                : $"{type.BaseType.Name}<TProps, {tElement}>";
            var properties = GetTypeProperties(type);
            var events = GetTypeEvents(type);
            var genericTypeParameters = type.GetTypeInfo().GenericTypeParameters;
            bool hasConstructor = type.GetConstructor(Type.EmptyTypes) != null;
            string additionalGenericParameters = $"{string.Join(", ", genericTypeParameters.Select(p => p.Name))}{(genericTypeParameters.Length > 0 ? ", " : "")}";
            var sb = new StringBuilder();
            if (settings.Namespaces != null)
            {
                foreach (string ns in settings.Namespaces)
                {
                    sb.AppendLine($"using {ns};");
                }
            }
            sb.AppendLine();
            sb.AppendLine($"namespace {rootNamespace}.Components");
            sb.AppendLine("{");
            sb.AppendLine($"\tpublic {(hasConstructor ? "": "abstract")} class {GetPureName(type.Name)}<{additionalGenericParameters}TProps{(type.IsSealed ? "": ", TElement")}>: {superClass}");
            sb.AppendLine($"\t\twhere TProps : Props.{GetTypeName(type)}");
            if (!type.IsSealed)
            {
                sb.AppendLine($"\t\twhere TElement : {GetTypeFullName(type)}");
            }
            sb.AppendLine("\t{");
            if (hasConstructor)
            {
                string cast = type.IsSealed ? "" : "(TElement)";
                sb.AppendLine("\t\tprotected override void CreateElement()");
                sb.AppendLine("\t\t{");
                sb.AppendLine($"\t\t\tElement = {cast}new {GetTypeFullName(type)}();");
                sb.AppendLine("\t\t}");
            }
            sb.AppendLine("\t\tpublic override void AssignProperties(TProps nextProps)");
            sb.AppendLine("\t\t{");
            sb.AppendLine($"\t\t\tbase.AssignProperties(nextProps);");
            foreach (var p in properties.Where(p => 
                !IsListProperty(p.PropertyType) 
                && !string.Equals(p.Name, propSettings.ContainerPropertyName, StringComparison.Ordinal)
                && !string.Equals(p.Name, propSettings.ChildrenContainerPropertyName, StringComparison.Ordinal)))
            {
                sb.AppendLine($"\t\t\tif (nextProps.{p.Name}.HasValue)");
                sb.AppendLine("\t\t\t{");
                sb.AppendLine($"\t\t\t\tElement.{p.Name} = nextProps.{p.Name}.Value.Value;");
                sb.AppendLine("\t\t\t}");
            }
            foreach (var e in events)
            {
                sb.AppendLine($"\t\t\tif (!ReferenceEquals(Props?.{e.Name}, null) && ReferenceEquals(nextProps.{e.Name}, null))");
                sb.AppendLine("\t\t\t{");
                sb.AppendLine($"\t\t\t\tElement.{e.Name} -= nextProps.{e.Name};");
                sb.AppendLine("\t\t\t}");
                sb.AppendLine($"\t\t\tif (ReferenceEquals(Props?.{e.Name}, null) && !ReferenceEquals(nextProps.{e.Name}, null))");
                sb.AppendLine("\t\t\t{");
                sb.AppendLine($"\t\t\t\tElement.{e.Name} += nextProps.{e.Name};");
                sb.AppendLine("\t\t\t}");
            }
            sb.AppendLine("\t\t}");
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            File.WriteAllText(path, sb.ToString());

        }

        static Type GetRootType(AppSettings config)
        {
            RootTypeSettings rootTypeSettings = config.RootType;
            string assemblyPath = GetAssemblyPath(config.RootAssemblyPath, rootTypeSettings.AssemblyPath);
            var assembly = LoadAssembly(assemblyPath);
            return assembly.GetType(rootTypeSettings.Name);
        }

        static string GetAssemblyPath(string root, string assemblyName)
        {
            return Path.Combine(root, $"{assemblyName}.dll"); ;
        }

        static Assembly LoadAssembly(string path)
        {
            var assembly = Assembly.ReflectionOnlyLoadFrom(path);
            foreach (var assemblyName in assembly.GetReferencedAssemblies())
            {
                Assembly.ReflectionOnlyLoad(assemblyName.FullName);
            }
            return assembly;
        }

        static AppSettings ReadSettings(string configFile)
        {
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(new CamelCaseNamingConvention())
                .Build();

            string configContent = File.ReadAllText(configFile);
            return deserializer.Deserialize<AppSettings>(configContent) ?? new AppSettings();
        }
    }
}
