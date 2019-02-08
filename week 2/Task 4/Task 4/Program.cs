using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();
            string sourcePath = @"C:\Users\profa\Desktop\KBTU\1-2\PP2\week 2\Task 4\input";
            string targetPath = @"C:\Users\profa\Desktop\KBTU\1-2\PP2\week 2\Task 4\output";
            string sourceFile = Path.Combine(sourcePath, filename);
            string destFile = Path.Combine(targetPath, filename);
            File.Create(sourcePath + @"\" + filename).Dispose();
            Console.WriteLine("Press SPACE to copy the file");
            ConsoleKeyInfo pressedKey = Console.ReadKey();
            if (pressedKey.Key == ConsoleKey.Spacebar)
            {
                File.Copy(sourceFile, destFile);
            }
            Console.WriteLine("Press Backspace to copy the file");
            ConsoleKeyInfo pressedKey2 = Console.ReadKey();
            if (pressedKey2.Key == ConsoleKey.Backspace) 
            {
                File.Delete(sourcePath + @"\" + filename);
            }

        }
    }
}
