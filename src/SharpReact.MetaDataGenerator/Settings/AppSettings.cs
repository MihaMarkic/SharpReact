using System.Collections.Generic;

namespace SharpReact.MetaDataGenerator.Settings
{
    public class AppSettings
    {
        public string OutputDirectory { get; set; }
        public string RootAssemblyPath { get; set; }
        public List<AssemblySettings> Assemblies { get; set; }
        public PropsSettings Properties { get; set; } = new PropsSettings();
        public ComponentSettings Components { get; set; } = new ComponentSettings();
        public RootTypeSettings RootType { get; set; }
        public string Namespace { get; set; }
    }
}
