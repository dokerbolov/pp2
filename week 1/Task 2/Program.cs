using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Student
    {
        public string name; // creating public variable "name"
        public string id; // creating public variable "id"
        public int year; // creating public variable "year"
        public Student(string name, string id, int year) // function that will get info of student
        {
            this.name = name; // our public "name" is equal to the public variable
            this.id = id;  // our public "id" is equal to the public variable
            this.year = year;  // our public "year" is equal to the public variable
        }
        public void PrintInfo() // function that will print the variables
        {
            Console.WriteLine(name); // prints name
            Console.WriteLine(id); // prints id
            Console.WriteLine(year); // prints year
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name of student: "); // it writes to the console "Enter name of student: " to clearify next step
            string name = Console.ReadLine(); // it reads the info from console
            Console.Write("Enter id of student: "); // it writes to the console "Enter id of student: " to clearify next step
            string id = Console.ReadLine(); // it reads the info from console
            Console.Write("Enter year of student: "); // it writes to the console "Enter year of student: " to clearify next step
            int year = Convert.ToInt32(Console.ReadLine()); // it reads the info from console
            Student student = new Student(name, id , year+1); // creating function, loading data that has been readed from the console, to the function
            student.PrintInfo(); // it`s making the 

        }
    }
}
