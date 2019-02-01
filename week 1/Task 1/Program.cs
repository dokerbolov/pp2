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
             int c = 0;  // creating counter that called "c"
             int n = int.Parse(Console.ReadLine()); // reading from the console variable "n", where is "n" length of massive
             int[] a = new int[n]; // creating massive "a" with the length "n" 
             for (int i = 0; i < n; i++) // for loop for the reading the variables to the massive "n" times
             {
                 a[i] = int.Parse(Console.ReadLine());
             }
             for (int i = 0; i < n; i++) // new loop to make a identifing operations "n" times for the "prime" number
                    {
                        if (a[i] == 1) // we know that "1" is not prime, we are checking for it
                        {
                            c++; // counter increases to "1"
                        }
                        for (int j = 2; j <= a[i]/2; j++) // this loop checks from "2", to the half of the number, further it will divide this numbers to the value of current massive number
                        {
                            if(a[i] % j == 0) // if value of current massive number is divided to our range("2" --> to the half) without the rest, then our counter increases to "1"
                            {
                                 c++; // counter increased to 1
                                 break; // it stops the loop
                            }
                        }
                     if (c == 0) // if counter equals to "0", then it doesn`t divided to our range, then it is prime number
                     {
                         Console.Write(a[i] + " "); // we print this number to the console, and add the free space(" ")
                     }
                     else // if counter more than "0", then it is not prime number
                     {
                         c = 0; // we are reseting counter to "0", we are doing it, two work with the new value of massive, when loop with the "i" changes to hte next
                     }
                   }
            Console.ReadKey();
        }
    }
}
