using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.Adapters
{
    public interface IStorageAdapter
    {
        List<string> ListFiles(string path);
        void ReadFile(string path);
        void WriteFile(string path, string content);
        void DeleteFile(string path);
    }
}
