using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Reading the lenth of massive where 'n' is length
            int[] a = new int[n]; // Creating massive that called 'a' with the length 'n'
            string s = Console.ReadLine(); // Reading new string
            string[] ss = s.Split(); // Creating string massive 'ss' and saving 's' string to it with split(deleting empty spaces)
            for (int i=0; i<n; i++) // Loop from 0 to 'n'
            {
                a[i] = int.Parse(ss[i]); // Rewriting from massive 'ss' to 'a' massive integers
                for (int j=0;j<2;j++) // loop from 0 to 2. Because we should show the elements of massive 2 times in this task
                {
                    Console.Write(a[i] + " "); // rewriting 'i-th' element of massive 'a' two times by using massive 'j'
                }
            }
            Console.ReadKey(); // To not close the console in debugging proccess 
        }
    }
}
