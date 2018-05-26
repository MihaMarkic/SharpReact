using System.Collections.Generic;

namespace SharpReact.MetaDataGenerator.Settings
{
    public class AppSettings
    {
        public string OutputDirectory { get; set; }
        public string RootAssemblyPath { get; set; }
        public List<AssemblySettings> Assemblies { get; set; }
        public List<string> Namespaces { get; set; }
        public RootTypeSettings RootType { get; set; }
    }
}
