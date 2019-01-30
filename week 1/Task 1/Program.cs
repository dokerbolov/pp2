 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
             int c = 0;
             int n = int.Parse(Console.ReadLine());
             int[] a = new int[n];
             for (int i = 0; i < n; i++)
             {
                 a[i] = int.Parse(Console.ReadLine());
             }
             for (int i = 0; i < n; i++)
                    {
                        if (a[i] == 1)
                        {
                            c++;
                        }
                        for (int j = 2; j <= a[i]/2; j++)
                        {
                            if(a[i] % j == 0)
                            {
                                 c++;
                                 break;
                            }
                        }
                     if (c == 0)
                     {
                         Console.Write(a[i] + " ");
                     }
                     else
                     {
                         c = 0;
                     }
                   }
            Console.ReadKey();
        }
    }
}
