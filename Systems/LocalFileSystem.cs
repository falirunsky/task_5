using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.Systems
{
    public class LocalFileSystem
    {
        public List<string> GetFiles(string path)
        {
            return new List<string> { "local1.txt", "local2.txt" };
        }

        public void Open(string path)
        {
            Console.WriteLine($"[Чтение локального файла: {path}]");
        }

        public void Save(string path, string content)
        {
            Console.WriteLine($"[Запись в локальный файл: {path}]");
        }

        public void Remove(string path)
        {
            Console.WriteLine($"[Удаление локального файла: {path}]");
        }
    }
}
