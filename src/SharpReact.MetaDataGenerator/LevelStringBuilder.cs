using System;
using System.Text;

namespace SharpReact.MetaDataGenerator
{
    public class LevelStringBuilder
    {
        public class Checkpoint : IDisposable
        {
            protected readonly LevelStringBuilder sb;
            readonly int level;
            public Checkpoint(LevelStringBuilder sb)
            {
                this.sb = sb;
                this.level = sb.Level;
            }
            public virtual void Dispose()
            {
                sb.Level = level;
            }
        }
        public class Method: Checkpoint
        {
            public Method(LevelStringBuilder sb) : base(sb)
            {
                sb.Open();
            }
            public override void Dispose()
            {
                base.Dispose();
                sb.Close();
            }
        }
        readonly StringBuilder sb;
        public int Level { get; set; }
        public void Open()
        {
            AppendLine("{");
        }
        public void Close()
        {
            AppendLine("}");
        }
        public LevelStringBuilder(StringBuilder sb)
        {
            this.sb = sb;
        }
        public Checkpoint AddLevel(int offset = 1)
        {
            var checkpoint = new Checkpoint(this);
            Level += offset;
            return checkpoint;
        }
        public Method AddMethod(string declaration)
        {
            AppendLine(declaration);
            var checkpoint = new Method(this);
            Level++;
            return checkpoint;
        }

        public void AppendLine(string text = null)
        {
            sb.AppendLine(Level, text);
        }

        public override string ToString() => sb.ToString();
    }
}
