using System;
using System.Collections.Generic;
using System.Text;
using task_5.Systems;

namespace task_5.Adapters
{
    public class CloudStorageAdapter : IStorageAdapter
    {
        private readonly CloudStorage _cloud;

        public CloudStorageAdapter(CloudStorage cloud)
        {
            _cloud = cloud;
        }

        public List<string> ListFiles(string path)
        {
            return _cloud.FetchObjects(path);
        }

        public void ReadFile(string path)
        {
            _cloud.Download(path);
        }

        public void WriteFile(string path, string content)
        {
            _cloud.Upload(path, content);
        }

        public void DeleteFile(string path)
        {
            _cloud.RemoveObject(path);
        }
    }
}
