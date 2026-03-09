using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.Systems
{
    public class CloudStorage
    {
        public List<string> FetchObjects(string bucket)
        {
            return new List<string> { "cloud_doc.txt", "backup.zip" };
        }

        public void Download(string key)
        {
            Console.WriteLine($"Скачиваю {key} из облака");
        }

        public void Upload(string key, string content)
        {
            Console.WriteLine($"Загружаю {key} в облако");
        }

        public void RemoveObject(string key)
        {
            Console.WriteLine($"Удаляю {key} с облака");
        }
    }
}
