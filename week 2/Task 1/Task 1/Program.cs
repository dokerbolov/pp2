using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = System.IO.File.ReadAllText(@"C:\Users\profa\Desktop\KBTU\1-2\PP2\week 2\Task 1\input.txt");
            bool ok = true;
            int k = s.Length;
            for (int i = 0; i < k/2; i++)
            {
                if (s[i] != s[k - 1 - i])
                {
                    ok = false;
                    break;
                }
            }
            if(ok == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
