using System;
using System.Text;
using task_5;
using task_5.Adapters;
using task_5.Composite;
using task_5.Systems;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        var root = new Folder("root");

        var docs = new Folder("docs");
        docs.Add(new FileItem("resume.pdf", 120));
        docs.Add(new FileItem("notes.txt", 10));

        var images = new Folder("images");
        images.Add(new FileItem("photo.jpg", 200));

        root.Add(docs);
        root.Add(images);

        root.Print("");
        Console.WriteLine($"[Общий размер: {root.GetSize()} кб]");


        var localAdapter = new LocalStorageAdapter(new LocalFileSystem());
        var cloudAdapter = new CloudStorageAdapter(new CloudStorage());


        var manager = new FileManagerFacade(localAdapter, cloudAdapter);

        manager.Backup("resume.pdf");
        manager.Sync("/");
    }
}