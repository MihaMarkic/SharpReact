namespace SharpReact.MetaDataGenerator.Settings
{
    public class PropsSettings : SectionSettings
    {
        public string ContainerPropertyName { get; set; }
        public string ChildrenContainerPropertyName { get; set; }
        public PropsSettings()
        {
            Path = "Props";
        }
    }
}
