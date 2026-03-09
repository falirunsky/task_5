using System;
using System.Collections.Generic;
using System.Text;
using task_5.Systems;

namespace task_5.Adapters
{
    public class LocalStorageAdapter : IStorageAdapter
    {
        private readonly LocalFileSystem _local;

        public LocalStorageAdapter(LocalFileSystem local)
        {
            _local = local;
        }

        public List<string> ListFiles(string path)
        {
            return _local.GetFiles(path);
        }

        public void ReadFile(string path)
        {
            _local.Open(path);
        }

        public void WriteFile(string path, string content)
        {
            _local.Save(path, content);
        }

        public void DeleteFile(string path)
        {
            _local.Remove(path);
        }
    }
}
