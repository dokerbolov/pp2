using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Example4
{
    class Program
    {
        static void Main()
        {
            int cnt = 0;
            DirectoryInfo dir = new DirectoryInfo(@"C:\сетевая папка");
            Address(dir, cnt);
        }
        public static void Address(DirectoryInfo dir1, int tab)
        {
            foreach (DirectoryInfo x in dir1.GetDirectories())
            {
                Space(tab);
                Console.WriteLine(x.Name);
                Address(x, tab + 1);
            }
            foreach (FileInfo y in dir1.GetFiles())
            {
                Space(tab);
                Console.WriteLine(y.Name);
            }

        }
        static void Space(int tab)
        {
            for(int i=0;i<tab;i++)
            {
                Console.Write("    ");
            }
        }
    }
}