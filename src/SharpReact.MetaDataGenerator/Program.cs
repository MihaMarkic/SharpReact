using SharpReact.MetaDataGenerator.Settings;
using System;
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
            if (config.UseCustomAssemblyResolver)
            {
                AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += CurrentDomain_ReflectionOnlyAssemblyResolve;
            }
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

        private static Assembly CurrentDomain_ReflectionOnlyAssemblyResolve(object sender, ResolveEventArgs args)
        {
            string[] paths =
            {
                "C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\Common7\\IDE\\ReferenceAssemblies\\Microsoft\\Framework\\MonoAndroid\\v1.0",
                "C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\Common7\\IDE\\ReferenceAssemblies\\Microsoft\\Framework\\MonoAndroid\\v1.0\\Facades"
            };
            string name = args.Name.Split(',')[0].Trim();
            string assemblyFileName = $"{name}.dll";
            foreach (string path in paths)
            {
                string assemblyPath = Path.Combine(path, assemblyFileName);
                if (File.Exists(assemblyPath))
                {
                    return Assembly.ReflectionOnlyLoadFrom(assemblyPath);
                }
            }
            throw new Exception($"Can't find assembly {args.Name}");
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
            CreateProperties(rootType, isRoot: true, config.OutputDirectory, config.Namespace, config);
            CreateComponents(rootType, isRoot: true, config.OutputDirectory, config);
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
                if (!file.EndsWith(".Extension.cs") && (settings.FixedFiles == null || Array.IndexOf(settings.FixedFiles, fileName) < 0))
                {
                    File.Delete(file);
                }
            }
        }

        static void ProcessAssembly(AppSettings config, Type rootType, AssemblySettings settings)
        {
            var ignoredTypes = new HashSet<string>(settings.IgnoredTypes ?? new string[0]);
            string assemblyPath = GetAssemblyPath(config.RootAssemblyPath, settings.Path);
            var assembly = LoadAssembly(assemblyPath, !config.UseCustomAssemblyResolver);
            var types = from t in assembly.GetTypes()
                        where t.IsPublic && t.IsSubclassOf(rootType) && !ignoredTypes.Contains(t.FullName)
                        select t;
            foreach (var type in types)
            {
                ProcessType(config, type);
            }
        }

        static void ProcessType(AppSettings config, Type type)
        {
            WriteLine($"\t{type.Name}");
            CreateProperties(type, isRoot: false, config.OutputDirectory, config.Namespace, config);
            CreateComponents(type, isRoot: false, config.OutputDirectory, config);
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
        static bool IsListProperty(Type type) => type.FullName == "System.Windows.Controls.UIElementCollection";
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
        static bool IsContentProperty(PropertyInfo pi, PropsSettings settings)
        {
            return string.Equals(pi.Name, settings.ContainerPropertyName, StringComparison.Ordinal);
        }
        static bool IsContainerProperty(PropertyInfo pi, PropsSettings settings)
        {
            return string.Equals(pi.Name, settings.ChildrenContainerPropertyName, StringComparison.Ordinal);
        }
        static bool IsContainerByInterface(Type type, string[] interfaces)
        {
            if (interfaces == null)
            {
                return false;
            }
            var allInterfaces = type.GetInterfaces();
            List<Type> baseTypes = new List<Type>();
            var current = type.BaseType;
            while (current != null)
            {
                baseTypes.Add(current);
                current = current.BaseType;
            }
            var implemented = allInterfaces.Except(baseTypes.SelectMany(t => t.GetInterfaces()));
            return implemented.Any(i => interfaces.Any(d => string.Equals(d, i.Name, StringComparison.Ordinal)));
        }
        static string GetBaseClassForProperties(bool isRoot, Type baseType)
        {
            if (isRoot)
            {
                return "Core.Properties.SharpNativeProp";
            }
            string definition;
            var genericArguments = baseType.GetTypeInfo().GetGenericArguments();
            if (genericArguments.Length > 0)
            {
                var arguments = genericArguments
                    .Select(a => $"global::{a.FullName}").ToArray();
                definition = $"<{string.Join(", ", arguments)}>";
            }
            else
            {
                definition = "";
            }

            string superClass = $"{GetPureName(baseType.Name)}{definition}";
            return superClass;
        }
        static void CreateProperties(Type type, bool isRoot, string outputDirectory, string rootNamespace, AppSettings appSettings)
        {
            var settings = appSettings.Properties;
            string path = Path.Combine(outputDirectory, settings.Path, $"{type.Name}.cs");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            string superClass = GetBaseClassForProperties(isRoot, type.BaseType);
            var properties = GetTypeProperties(type);
            var events = GetTypeEvents(type);
            var lastProperty = properties.LastOrDefault();
            var sb = new LevelStringBuilder(new StringBuilder());
            bool isAbstract = IsTypeAbstract(type, appSettings.Components.ElementsRequiresConstructor);
            string abstractType = isAbstract ? " abstract" : "";
            string implementedInterfaces = "";

            if (settings.Namespaces != null)
            {
                foreach (string ns in settings.Namespaces)
                {
                    sb.AppendLine($"using {ns};");
                }
            }
            sb.AppendLine();
            using (sb.AddMethod($"namespace {rootNamespace}.Props"))
            {
                sb.AppendLine($"public{abstractType} partial class {GetTypeName(type)}: {superClass}{implementedInterfaces}");
                foreach (var genericParameter in type.GetTypeInfo().GenericTypeParameters)
                {
                    var constraints = genericParameter.GetGenericParameterConstraints();
                    {
                        if (constraints.Length > 0)
                        {
                            using (sb.AddLevel())
                            {
                                sb.AppendLine($"where {genericParameter.Name}: {string.Join(", ", constraints.Select(c => $"global::{c.FullName}"))} ");
                            }
                        }
                    }
                }
                sb.Open();
                using (sb.AddLevel())
                {
                    var contentProperties = new List<PropertyInfo>();
                    var containerProperties = new List<PropertyInfo>();
                    var containerPropertyNames = new List<string>();
                    string typeName = type.Name;
                    foreach (var p in properties)
                    {
                        if (IsContentProperty(p, settings))
                        {
                            contentProperties.Add(p);
                            sb.AppendLine($"public ISharpProp {p.Name} {{ get; set; }}");
                        }
                        else if (IsContainerProperty(p, settings) || IsListProperty(p.PropertyType))
                        {
                            containerProperties.Add(p);
                            containerPropertyNames.Add(p.Name);
                            sb.AppendLine($"public List<ISharpProp> {p.Name} {{ get; set; }} = new List<ISharpProp>();");
                        }
                        else
                        {
                            sb.AppendLine($"public ReactParam<{GetPropertyType(p.PropertyType)}>? {p.Name} {{ get; set; }}");
                        }
                    }
                    bool hasContainerByProperty = IsContainerByInterface(type, appSettings.ContainerInterfaces);
                    if (hasContainerByProperty)
                    {
                        containerPropertyNames.Add(appSettings.CustomContainerProperty);
                        sb.AppendLine($"public List<ISharpProp> {appSettings.CustomContainerProperty} {{ get; set; }} = new List<ISharpProp>();");
                    }
                    foreach (var e in events)
                    {
                        sb.AppendLine($"public {GetEventTypeFullName(e.EventHandlerType)} {e.Name} {{ get; set; }}");
                    }
                    if (!isAbstract)
                    {
                        using (sb.AddMethod("protected override ISharpStatefulComponent CreateComponent()"))
                        {

                            string tElement = type.IsSealed ? "" : $", global::{GetTypeFullName(type)}";
                            string additionalTypeParameters = type.IsGenericType ? string.Join(",", type.GetTypeInfo().GenericTypeParameters.Select(a => a.Name)) + ", " : "";
                            sb.AppendLine($"return new Components.{GetPureName(type.Name)}<{additionalTypeParameters}{GetTypeName(type)}{tElement}>();");
                        }
                    }
                    if (contentProperties.Count + containerProperties.Count > 0)
                    {
                        using (sb.AddMethod("protected override void UnmountComponent()"))
                        {
                            foreach (var p in contentProperties)
                            {
                                sb.AppendLine($"UnmountComponent({p.Name});");
                            }
                            foreach (var p in containerProperties)
                            {
                                sb.AppendLine($"UnmountComponents({p.Name});");
                            }
                            if (hasContainerByProperty)
                            {
                                sb.AppendLine($"UnmountComponents({appSettings.CustomContainerProperty});");
                            }
                            sb.AppendLine("base.UnmountComponent();");
                        }
                    }
                    if (properties.Length > 0)
                    {
                        using (sb.AddMethod($"public override IEnumerable<IReactParam> AllProperties"))
                        {
                            using (sb.AddMethod("get"))
                            {
                                foreach (var p in properties)
                                {
                                    sb.AppendLine($"yield return {p.Name};");
                                }
                                using (sb.AddMethod("foreach (var p in base.AllProperties)"))
                                {
                                    sb.AppendLine("yield return p;");
                                }
                            }
                        }
                    }
                    if (contentProperties.Count + containerProperties.Count > 0 || hasContainerByProperty)
                    {
                        using (sb.AddMethod("public override IEnumerable<ISharpProp> AllChildren"))
                        {
                            using (sb.AddMethod("get"))
                            {
                                List<string> containerPropertiesNames = new List<string>(containerProperties.Select(p => p.Name));
                                if (hasContainerByProperty)
                                {
                                    containerPropertiesNames.Add(appSettings.CustomContainerProperty);
                                }

                                foreach (var c in containerPropertiesNames)
                                {
                                    using (sb.AddMethod($"foreach (var c in {c})"))
                                    {
                                        sb.AppendLine("yield return c;");
                                    }
                                }
                                foreach (var c in contentProperties)
                                {
                                    sb.AppendLine($"yield return {c.Name};");
                                }
                                using (sb.AddMethod("foreach (var c in base.AllChildren)"))
                                {
                                    sb.AppendLine("yield return c;");
                                }
                            }
                        }
                    }
                    if (containerPropertyNames.Count > 0)
                    {
                        foreach (var name in containerPropertyNames)
                        {
                            sb.AppendLine($"public IEnumerable<ISharpProp> Add{name} {{ set => {name}.AddRange(value); }}");
                        }
                    }
                }
                sb.Close();
            }
            File.WriteAllText(path, sb.ToString());
        }
        static bool IsTypeCreatable(Type type)
        {
            return !type.IsAbstract && type.IsPublic && type.GetConstructor(Type.EmptyTypes) != null;
        }
        static string GetPropertyType(Type type)
        {
            string fullName;
            if (type.IsGenericParameter)
            {
                return type.Name;
            }
            if (type.IsNested)
            {
                fullName = $"{type.DeclaringType.FullName}.{type.Name}";
            }
            else
            {
                fullName = type.FullName;
            }
            if (type.IsGenericType)
            {
                return $"global::{GetPureName(fullName)}<{type.GenericTypeArguments[0].FullName}>";
            }
            else
            {
                return $"global::{fullName}";
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
            string name;
            if (argument.IsGenericParameter)
            {
                return argument.Name;
            }
            if (argument.IsNested)
            {
                name = $"{argument.DeclaringType.Name}.{argument.Name}";
            }
            else
            {
                name = argument.Name;
            }
            return $"global::{argument.Namespace}.{name}";
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
        static string GetBaseClassForComponents(bool isRoot, Type baseType, string rootElement, string tElement)
        {
            if (isRoot)
            {
                return $"{rootElement}<TProps, object, TElement>";
            }
            var genericArguments = baseType.GetTypeInfo().GetGenericArguments()
                .Select(a => $"global::{a.FullName}").ToArray();
            var definition = string.Join(", ", genericArguments) + (genericArguments.Length > 0 ? ", " : "");

            string superClass = $"{GetPureName(baseType.Name)}<{definition}TProps, {tElement}>";
            return superClass;
        }
        static bool IsTypeAbstract(Type type, bool elementsRequiresConstructor)
        {
            bool hasConstructor = type.GetConstructor(Type.EmptyTypes) != null;
            bool isAbstract = type.IsAbstract || elementsRequiresConstructor && !hasConstructor;
            return isAbstract;
        }
        static void CreateComponents(Type type, bool isRoot, string outputDirectory, AppSettings settings)
        {
            string typeName = type.Name;
            string path = Path.Combine(outputDirectory, settings.Components.Path, $"{type.Name}.cs");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            string tElement = type.IsSealed ? $"global::{GetTypeFullName(type)}" : "TElement";
            string superClass = GetBaseClassForComponents(isRoot, type.BaseType, settings.Components.RootElement, tElement);
            var properties = GetTypeProperties(type);
            var events = GetTypeEvents(type);
            var genericTypeParameters = type.GetTypeInfo().GenericTypeParameters;
            bool isAbstract = IsTypeAbstract(type, settings.Components.ElementsRequiresConstructor);
            string additionalGenericParameters = $"{string.Join(", ", genericTypeParameters.Select(p => p.Name))}{(genericTypeParameters.Length > 0 ? ", " : "")}";
            var sb = new LevelStringBuilder(new StringBuilder());
            if (settings.Components.Namespaces != null)
            {
                foreach (string ns in settings.Components.Namespaces)
                {
                    sb.AppendLine($"using {ns};");
                }
            }
            sb.AppendLine();
            string classPureName = GetPureName(type.Name);
            var containerProperties = properties.Where(p => IsContainerProperty(p, settings.Properties)).ToArray();
            var contentProperties = properties.Where(p => IsContentProperty(p, settings.Properties)).ToArray();
            var nonContentOrContainerProperties = properties.Except(containerProperties).Except(contentProperties).ToArray();
            bool isContainerByInterface = IsContainerByInterface(type, settings.ContainerInterfaces);
            using (sb.AddMethod($"namespace {settings.Namespace}.Components"))
            {
                sb.AppendLine($"public {(isAbstract ? "abstract" : "")} partial class {classPureName}<{additionalGenericParameters}TProps{(type.IsSealed ? "" : ", TElement")}>: {superClass}");
                using (sb.AddLevel())
                {
                    sb.AppendLine($"where TProps : Props.{GetTypeName(type)}");
                    if (!type.IsSealed)
                    {
                        string newConstraint = settings.Components.ElementsRequiresConstructor ? ", new()" : "";
                        sb.AppendLine($"where TElement : global::{GetTypeFullName(type)}{newConstraint}");
                    }
                    foreach (var genericParameter in type.GetTypeInfo().GenericTypeParameters)
                    {
                        var constraints = genericParameter.GetGenericParameterConstraints();
                        if (constraints.Length > 0)
                        {
                            sb.AppendLine($"where {genericParameter.Name}: {string.Join(", ", constraints.Select(c => $"global::{c.FullName}"))} ");
                        }
                    }
                }
                sb.Open();
                using (sb.AddLevel())
                {
                    // CreateElement
                    if (!isAbstract)
                    {
                        var source = type.IsSealed ? settings.Components.SealedElementCreation : settings.Components.ElementCreation;
                        if (source?.Length > 0)
                        {
                            string elementType = $"global::{GetTypeFullName(type)}";
                            foreach (string line in source)
                            {
                                sb.AppendLine(line.Replace("[TElement]", elementType));
                            }
                        }
                        if (settings.Components.InitElementPartial)
                        {
                            sb.AppendLine($"partial void InitElement({tElement} element);");
                        }
                    }
                    if (properties.Length > 0 || isContainerByInterface)
                    {
                        using (sb.AddMethod($"public override void AssignProperties(ISharpRenderer<global::{settings.RootType.Name}> renderer, int level, NewState newState, TProps previous, TProps nextProps)"))
                        {
                            sb.AppendLine($"base.AssignProperties(renderer, level, newState, previous, nextProps);");
                            if (nonContentOrContainerProperties.Length > 0)
                            {
                                sb.AppendLine($"Update{classPureName}WithInstanceProperties(Element, previous, nextProps);");
                            }
                            foreach (var p in contentProperties)
                            {
                                using (sb.AddMethod($"if (nextProps.{p.Name} != null)"))
                                {
                                    sb.AppendLine($"Element.{p.Name} = renderer.ProcessPair(level + 1, newState, previous?.{p.Name}, nextProps.{p.Name});");
                                }
                            }
                            if (containerProperties.Length > 0 || isContainerByInterface)
                            {
                                string propertyName;
                                if (containerProperties.Length > 0)
                                {
                                    propertyName = containerProperties[0].Name;
                                }
                                else
                                {
                                    propertyName = settings.CustomContainerProperty;
                                }
                                sb.AppendLine($"AssignContainerProperties(renderer, level, newState, previous?.{propertyName}, nextProps.{propertyName}, nameof({settings.Namespace}.{settings.Properties.Path}.{GetPureName(type.Name)}.{propertyName}), nameof({settings.Namespace}.{settings.Properties.Path}.{GetPureName(type.Name)}));");
                            }
                            //if (isContainerByInterface)
                            //{
                            //    string propName = settings.CustomContainerProperty;
                            //    string sourceTypeName = $"{settings.Namespace}.{settings.Properties.Path}.{GetPureName(type.Name)}";
                            //    sb.Open();
                            //    using (sb.AddLevel())
                            //    {
                            //        sb.AppendLine("var elements = renderer.VisitAllCollection(level, newState, previous, nextProps, propertyName, containerName);");
                            //        sb.AppendLine($"{settings.Components.ElementsSynchronization}");
                            //    }
                            //    sb.Close();
                            //}
                            if (settings.Components.PostAssignPropertiesPartial)
                            {
                                sb.AppendLine($"PostAssign{classPureName}Properties(renderer, level, newState, previous, nextProps);");
                            }
                        }
                        if (containerProperties.Length > 0 || isContainerByInterface)
                        {
                            using (sb.AddMethod($"public override void AssignContainerProperties(ISharpRenderer<global::{settings.RootType.Name}> renderer, int level, NewState newState, List<ISharpProp> previous, List<ISharpProp> nextProps, string propertyName, string containerName)"))
                            {
                                //foreach (var p in containerProperties)
                                //{
                                    //sb.Open();
                                    //using (sb.AddLevel())
                                    //{
                                        sb.AppendLine($"var elements = renderer.VisitAllCollection(level, newState, previous, nextProps, propertyName, containerName);");
                                        sb.AppendLine($"{settings.Components.ElementsSynchronization}");
                                    //}
                                    //sb.Close();
                                //}
                            }
                        }
                    }
                    if (settings.Components.PostAssignPropertiesPartial)
                    {
                        sb.AppendLine($"partial void PostAssign{classPureName}Properties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);");
                    }
                    if (nonContentOrContainerProperties.Length > 0)
                    {
                        using (sb.AddMethod($"protected override void UpdateElement(ISharpRenderer renderer, {tElement} element, TProps props)"))
                        {
                            sb.AppendLine("base.UpdateElement(renderer, element, props);");
                            sb.AppendLine($"Update{classPureName}WithInstanceProperties(element, null, props);");
                        }
                        using (sb.AddMethod($"static void Update{classPureName}WithInstanceProperties({tElement} element, TProps previous, TProps nextProps)"))
                        {
                            foreach (var p in nonContentOrContainerProperties)
                            {
                                if (!IsContentProperty(p, settings.Properties) && !IsContainerProperty(p, settings.Properties))
                                {
                                    using (sb.AddMethod($"if (nextProps.{p.Name}.HasValue)"))
                                    {
                                        sb.AppendLine($"element.{p.Name} = nextProps.{p.Name}.Value.Value;");
                                    }
                                }
                            }
                            foreach (var e in events)
                            {
                                using (sb.AddMethod($"if (!(previous?.{e.Name} is null) && nextProps.{e.Name} is null)"))
                                {
                                    sb.AppendLine($"element.{e.Name} -= nextProps.{e.Name};");
                                }
                                using (sb.AddMethod($"if (previous?.{e.Name} is null && !(nextProps.{e.Name} is null))"))
                                {
                                    sb.AppendLine($"element.{e.Name} += nextProps.{e.Name};");
                                }
                            }
                        }
                    }
                }
                sb.Close();
            }
            File.WriteAllText(path, sb.ToString());
        }

        static Type GetRootType(AppSettings config)
        {
            RootTypeSettings rootTypeSettings = config.RootType;
            string assemblyPath = GetAssemblyPath(config.RootAssemblyPath, rootTypeSettings.AssemblyPath);
            var assembly = LoadAssembly(assemblyPath, !config.UseCustomAssemblyResolver);
            return assembly.GetType(rootTypeSettings.Name);
        }

        static string GetAssemblyPath(string root, string assemblyName)
        {
            return Path.Combine(root, $"{assemblyName}.dll"); ;
        }

        static Assembly LoadAssembly(string path, bool loadReferenced)
        {
            var assembly = Assembly.ReflectionOnlyLoadFrom(path);
            if (loadReferenced)
            {
                foreach (var assemblyName in assembly.GetReferencedAssemblies())
                {
                    Assembly.ReflectionOnlyLoad(assemblyName.FullName);
                }
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
