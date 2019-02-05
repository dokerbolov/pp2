using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            string s = System.IO.File.ReadAllText(@"C:\Users\profa\Desktop\KBTU\1-2\PP2\week 2\Task 2\input.txt");
            string[] ss = s.Split();
            int[] a = new int[ss.Length];
            string k = null;
            for (int i = 0; i < ss.Length; i++)
            {
                a[i] = int.Parse(ss[i]);
                if(a[i] == 1)
                {
                    cnt++;
                }
                for (int j = 2; j <= a[i] / 2; j++)
                {
                    if (a[i] % j == 0 )
                    {
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0)
                {
                    k = k + a[i] + " ";
                }
                else
                {
                    cnt = 0;
                }
            }
            System.IO.File.WriteAllText(@"C:\Users\profa\Desktop\KBTU\1-2\PP2\week 2\Task 2\output.txt", k);
        }
    }
}
