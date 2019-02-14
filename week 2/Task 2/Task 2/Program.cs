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
            int cnt = 0; // creating counter that strats from "0"
            string s = System.IO.File.ReadAllText(@"C:\Users\profa\Desktop\KBTU\1-2\PP2\week 2\Task 2\input.txt"); //reading the value of string from the txt file on folder(by link)
            string[] ss = s.Split(); // creating string array "ss" that has value of splited(without spaces) "s"
            int[] a = new int[ss.Length]; // creating new array with length "ss"
            string k = null; // empty string "k"
            for (int i = 0; i < ss.Length; i++) // loop from "0" to "ss.length"
            {
                a[i] = int.Parse(ss[i]); // rewriting "ss" array to the "a"(converting string to int)
                if(a[i] == 1) // if "i"-th element of array equal to "1" 
                {
                    cnt++; // cnt growth
                }
                for (int j = 2; j <= a[i] / 2; j++) // loop from "2" to the half of the number on "i"-th element of array
                {
                    if (a[i] % j == 0 ) // if "i"-th element of array divideds to j without reminder
                    {
                        cnt++; // cnt growth
                        break; // loop stops
                    }
                }
                if (cnt == 0) // if cnt = 0
                {
                    k = k + a[i] + " "; // string "k" is adding by our "i"-th element of array "a"
                }
                else
                {
                    cnt = 0; // cnt is reset to zero
                }
            }
            System.IO.File.WriteAllText(@"C:\Users\profa\Desktop\KBTU\1-2\PP2\week 2\Task 2\output.txt", k); // string "k" will be writed on the "output.txt"
        }
    }
}
