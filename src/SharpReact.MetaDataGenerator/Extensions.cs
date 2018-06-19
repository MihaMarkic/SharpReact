using System;
using System.Linq;
using System.Text;

namespace SharpReact.MetaDataGenerator
{
    public static class Extensions
    {
        const int TabsMax = 10;
        static string[] tabs;
        static Extensions()
        {
            tabs = Enumerable.Range(0, TabsMax)
                .Select(r => new string('\t', r))
                .ToArray();
        }
        public static void AppendLine(this StringBuilder sb, int level, string text)
        {
            if (level >= TabsMax)
            {
                throw new ArgumentException(nameof(level));
            }
            sb.AppendLine($"{tabs[level]}{text}");
        }
    }
}
