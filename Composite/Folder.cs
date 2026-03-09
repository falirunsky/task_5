using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.Composite
{
    public class Folder : FileSystemItem
    {
        private readonly List<FileSystemItem> _children = new();

        public Folder(string name) : base(name) { }

        public void Add(FileSystemItem item)
        {
            _children.Add(item);
        }

        public void Remove(FileSystemItem item)
        {
            _children.Remove(item);
        }

        public override int GetSize()
        {
            int total = 0;

            foreach (var child in _children)
            {
                total += child.GetSize();
            }

            return total;
        }

        public override void Print(string indent)
        {
            Console.WriteLine($"{indent}[{Name}]");

            foreach (var child in _children)
            {
                child.Print(indent + "  ");
            }
        }

        public List<FileSystemItem> GetChildren()
        {
            return _children;
        }
    }
}
