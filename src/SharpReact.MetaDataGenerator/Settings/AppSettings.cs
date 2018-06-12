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
        public bool UseCustomAssemblyResolver { get; set; }
        public string[] CustomAssemblyPaths { get; set; }
        public string Namespace { get; set; }
        /// <summary>
        /// When container is derived from interface implementation
        /// </summary>
        public string[] ContainerInterfaces { get; set; }
        /// <summary>
        /// When container is derived from interface, then it needs a custom property for collection
        /// </summary>
        public string CustomContainerProperty { get; set; }
    }
}
