using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SelfCSharp.Ch05
{
    class FileProcess
    {
        static void Main(string[] args)
        {
            var file = new FileInfo(@"C:\Users\yamak\tmp\sample.txt");

            Console.WriteLine(file.Exists);
            Console.WriteLine(file.Name);
            Console.WriteLine(file.DirectoryName);
            Console.WriteLine(file.IsReadOnly);
            Console.WriteLine(file.LastAccessTime);
            Console.WriteLine(file.LastWriteTime);
            Console.WriteLine(file.Length);

            var file2 = file.CopyTo(@"C:\Users\yamak\tmp\sample_copy.txt", true);
            file2.MoveTo(@"C:\Users\yamak\tmp\data\sample_copy.txt");
            file2.MoveTo(@"C:\Users\yamak\tmp\data\sample_renamed.txt");
            file2.Delete();

            // Directory
            var dir = new DirectoryInfo(@"C:\Users\yamak\tmp\SelfCSharp");

            Console.WriteLine(dir.Exists);
            Console.WriteLine(dir.Parent);
            Console.WriteLine(dir.Root);
            Console.WriteLine(dir.CreationTime);
            Console.WriteLine(dir.LastAccessTime);
            Console.WriteLine(dir.LastWriteTime);

            // サブフォルダ
            var dirs = dir.GetDirectories();
            foreach (var d in dirs) 
            {
                Console.WriteLine(d.FullName);
            }

            // 作成
            var dir2 = new DirectoryInfo(@"C:\Users\yamak\tmp\smp");
            dir2.Create();

            // 変更
            dir2.MoveTo(@"C:\Users\yamak\tmp\test");

            // フォルダの移動
            dir2.MoveTo(@"C:\Users\yamak\tmp\SelfCSharp\test");

            // サブフォルダの作成
            dir2.CreateSubdirectory("sub");

            // 削除
            //dir2.Delete();
        }
    }
}
