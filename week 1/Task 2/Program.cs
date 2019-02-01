using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Student
    {
        public string name;
        public string id;
        public string year;
        public Student(string name, string id, string year)
        {
            this.name = name;
            this.id = id;
            this.year = year;
        }
        public void PrintInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
            Console.WriteLine(year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Yeldos", "18BD111111", "2019");
            student.PrintInfo();

        }
    }
}
