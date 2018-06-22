using System.Collections.Generic;
using System.IO;

namespace SharpReact.MetaDataGenerator.Settings
{
    /// <summary>
    /// Template based assembly list.
    /// </summary>
    public class AssembliesTemplateSource
    {
        /// <summary>
        /// [VERSION] part for <see cref="Template" />.
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// Template path for assemblies.
        /// </summary>
        public string Template { get; set; }
        /// <summary>
        /// [NAME] part for <see cref=" Template"/>.
        /// </summary>
        public string[] Names { get; set; }
        public string[] IgnoredTypes { get; set; }
        public IEnumerable<string> GetFullPaths(string root)
        {
            foreach (string name in Names)
            {
                string relative = Template.Replace("[NAME]", name).Replace("[VERSION]", Version);
                yield return Path.Combine(root, relative);
            }
        }
        public string GetFullPath(string root, string name)
        {
            string relative = Template.Replace("[NAME]", name).Replace("[VERSION]", Version);
            return Path.Combine(root, relative);
        }
    }
}
