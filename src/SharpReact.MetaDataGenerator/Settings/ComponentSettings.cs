namespace SharpReact.MetaDataGenerator.Settings
{
    public class ComponentSettings: SectionSettings
    {
        /// <summary>
        /// Specifies whether new() generic constraint is applied to TElement
        /// </summary>
        public bool ElementsRequiresConstructor { get; set; }
        public string ElementsSynchronization { get; set; }
        /// <summary>
        /// All components derive from this guy
        /// </summary>
        public string RootElement { get; set; }
        /// <summary>
        /// Custom element instance creation. [TElement] is special word that gets substituted at generation with TElement type.
        /// </summary>
        public string[] ElementCreation { get; set; }
        public string[] SealedElementCreation { get; set; }
        public ComponentSettings()
        {
            Path = "Components";
        }
    }
}
