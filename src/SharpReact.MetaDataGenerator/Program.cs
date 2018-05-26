using SharpReact.MetaDataGenerator.Settings;
using System.IO;
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
            Process(config);
#if DEBUG
            WriteLine("Done");
            ReadLine();
#endif
            return 0;
        }

        static void Process(AppSettings config)
        {

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
