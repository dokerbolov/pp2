using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_1
{
    public class Marking
    {
        public int mark;
        public void Getletter(int mark)
        {
            if (mark >= 95 && mark <= 100)
            {
                Console.WriteLine("A");
            }
            else if (mark >= 90 && mark < 95)
            {
                Console.WriteLine("A-");
            }
            else if (mark >= 85 && mark < 90)
            {
                Console.WriteLine("B+");
            }
            else if (mark >= 80 && mark < 85)
            {
                Console.WriteLine("B");
            }
            else if (mark >= 75 && mark < 80)
            {
                Console.WriteLine("B-");
            }
            else if (mark >= 70 && mark < 75)
            {
                Console.WriteLine("C+");
            }
            else if (mark >= 65 && mark < 70)
            {
                Console.WriteLine("C");
            }
            else if (mark >= 60 && mark < 65)
            {
                Console.WriteLine("C-");
            }
            else if (mark >= 55 && mark < 60)
            {
                Console.WriteLine("D+");
            }
            else if (mark >= 50 && mark < 55)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int cnt=0;
            List<int> numbers = new List<int>();
            F2();
            foreach(int i in numbers)
            {
                cnt = cnt + i;
            }
        }
            private static void F2()

            {
                FileStream fs = new FileStream("student.txt", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Marking));
                Marking t = xs.Deserialize(fs) as Marking;
                fs.Close();
            }
            private static void F1()
            {
                Marking s = new Marking();
                FileStream fs = new FileStream("student.txt", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Marking));
                xs.Serialize(fs, s);
                fs.Close();
            }
    }
}

