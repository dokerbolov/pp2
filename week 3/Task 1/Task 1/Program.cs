using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class FarManager
    {
        public int index = 0;
        public string path;
        public int size;
        public bool ok;
        DirectoryInfo directory = null;
        FileSystemInfo currentfs = null;
        public FarManager(string path)
        {
            this.path = path;
            index = 0;
            directory = new DirectoryInfo(path);
            size = directory.GetFileSystemInfos().Length;
            ok = true;
        }
        public void Color(FileSystemInfo fs, int pos)
        {
            if (index == pos)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                currentfs = fs;
            }
            else 
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            DirectoryInfo[] di = directory.GetDirectories();
            FileInfo[] fi = directory.GetFiles();
            for (int i = 0; i < di.Length; i++)
            {
                fs[i] = di[i];
            }
            for (int i = 0; i < fi.Length; i++)
            {
                fs[i + di.Length] = fi[i];
            }
            for (int i = 0, k = 0; i < fs.Length; i++)
            {
                Color(fs[i], k);
                Console.WriteLine(fs[i].Name);
                k++;
            }
        }
        public void Start()
        {
            bool kk = false;
            while (!kk)
            {
                Show();
                ConsoleKeyInfo pressedkey = Console.ReadKey();
                switch (pressedkey.Key)
                {
                    case ConsoleKey.UpArrow:
                        index--;
                        if (index < 0)
                            index = size - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        index++;
                        if (index == size)
                            index = 0;
                        break;
                    case ConsoleKey.Enter:
                        if (currentfs.GetType() == typeof(DirectoryInfo))
                        {
                            index = 0;
                            path = currentfs.FullName;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            string path12 = currentfs.FullName;
                            string s1 = File.ReadAllText(path12);
                            Console.Write(s1);
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.Backspace:
                        index = 0;
                        path = directory.Parent.FullName;
                        break;
                    case ConsoleKey.Delete:
                        if (currentfs.GetType() == typeof(DirectoryInfo))
                        {
                            string path12 = currentfs.FullName;
                            Directory.Delete(path12, true);
                        }
                        else
                        {
                            string pathFile = currentfs.FullName;
                            File.Delete(pathFile);
                        }
                        break;
                    case ConsoleKey.F4:
                        string path1 = directory.FullName;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine("Create new name");
                        string name = Console.ReadLine();
                        if (currentfs.GetType() == typeof(FileInfo))
                        {
                            string sourcefile = currentfs.FullName;
                            string destfile = path1 + @"\" + name;
                            File.Move(sourcefile, destfile);
                        }
                        else
                        if (currentfs.GetType() == typeof(DirectoryInfo))
                        {
                            string sourcedir = currentfs.FullName;
                            string destdir = Path.Combine(path1, name);
                            Directory.Move(sourcedir, destdir);
                        }
                        break;
                    case ConsoleKey.Escape:
                        ok = true;
                        break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\profa\Desktop\123";
            FarManager farmanager = new FarManager(path);
            farmanager.Start();
        }
    }
}