namespace SharpReact.MetaDataGenerator.Settings
{
    public abstract class SectionSettings
    {
        public string[] Namespaces { get; set; }
        public string[] FixedFiles { get; set; }
        public string Path { get; set; }
    }
}
