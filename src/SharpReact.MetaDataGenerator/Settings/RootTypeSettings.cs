namespace SharpReact.MetaDataGenerator.Settings
{
    public class RootTypeSettings
    {
        public string AssemblyPath { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// When false, no root type code related is output.
        /// Use when building implementations that rely on core implementation.
        /// </summary>
        public bool IsOutput { get; set; } = true;
    }
}
