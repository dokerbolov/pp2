﻿using System;
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
            int cnt = 0; // variable cnt for "tab"
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\profa\Desktop\123"); // path of folder
            Address(dir, cnt); // function
        }
        public static void Address(DirectoryInfo dir1, int tab) // function that will divide directories and files with the tabulation
        {
            foreach (DirectoryInfo x in dir1.GetDirectories()) // it will recognise what is the directory and say it "x"
            {
                Space(tab); // making tabulation foreach directory
                Console.WriteLine(x.Name); // it will writeline the name of the folder
                Address(x, tab + 1); // recursion to repeat this fucntion with the tabulation increasing
            }
            foreach (FileInfo y in dir1.GetFiles()) // it will recognise what is the file and say it is like "y"
            {
                Space(tab); // making tabulation for each file, that is currently located in the folder
                Console.WriteLine(y.Name); // writing the name of the file
            }
        }
        static void Space(int tab) // function to add "tabs"(tabulation)
        {
            for(int i=0;i<tab;i++) // loop for how many "tab" will be
            { 
                Console.Write("    "); // spaces of "tab"
            }
        }
    }
}