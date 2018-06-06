namespace SharpReact.MetaDataGenerator.Settings
{
    public class ComponentSettings: SectionSettings
    {
        /// <summary>
        /// Specifies whether new() generic constraint is applied to TElement
        /// </summary>
        public bool ElementsRequiresConstructor { get; set; }
        public ComponentSettings()
        {
            Path = "Components";
        }
    }
}
