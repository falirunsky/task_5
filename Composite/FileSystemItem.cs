using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.Composite
{
    public abstract class FileSystemItem
    {
        public string Name { get; }

        protected FileSystemItem(string name)
        {
            Name = name;
        }

        public abstract int GetSize();
        public abstract void Print(string indent);
    }
}
