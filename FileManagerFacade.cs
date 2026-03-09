using System;
using System.Collections.Generic;
using System.Text;
using task_5.Adapters;

namespace task_5
{
    public class FileManagerFacade
    {
        private readonly IStorageAdapter _local;
        private readonly IStorageAdapter _cloud;

        public FileManagerFacade(IStorageAdapter local, IStorageAdapter cloud)
        {
            _local = local;
            _cloud = cloud;
        }

        public void Backup(string localFile)
        {
            Console.WriteLine("[Создаю резервное копирование...]");

            _local.ReadFile(localFile);
            _cloud.WriteFile(localFile, "data");

            Console.WriteLine("[Резервное копирование завершено]");
        }

        public void Sync(string path)
        {
            Console.WriteLine("[Начало синхронизации]");

            var localFiles = _local.ListFiles(path);

            foreach (var file in localFiles)
            {
                _cloud.WriteFile(file, "data");
            }

            Console.WriteLine("[Конец синхронизации]");
        }
    }
}
