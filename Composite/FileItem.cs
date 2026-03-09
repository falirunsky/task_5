using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.Composite
{
    public class FileItem : FileSystemItem
    {
        public int Size { get; }

        public FileItem(string name, int size) : base(name)
        {
            Size = size;
        }

        public override int GetSize()
        {
            return Size;
        }

        public override void Print(string indent)
        {
            Console.WriteLine($"{indent} - {Name} ({Size} кб.)");
        }
    }
}
