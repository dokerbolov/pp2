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
            int n = Convert.ToInt32(Console.ReadLine()); // it`s  reading the variable "n" 
            string[,] a = new string[n, n]; // creating two-dimesional array with the lengthes "n" that called "a"
            for (int i=0;i<n;i++) // loop from "0" to "n"
            {
                for (int j=0;j<=i;j++) // second loop from "0" to "i"
                {
                    a[i, j] = "[*]"; // it`s saving in array at the cordinate [i,j] symbol "*"
                    Console.Write(a[i, j]); // printing cordinate
                }
                Console.WriteLine(); // scapes one line down
            }
            
        }
    }
}
