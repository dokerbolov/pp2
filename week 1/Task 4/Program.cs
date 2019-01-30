using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[,] a = new string[n, n];
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<=i;j++)
                {
                    a[i, j] = "[*]";
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
