using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_CS
{
    internal class Program
    {
        public static string delimiter = "\n------------------------------------------------\n";
        static void Main(string[] args)
        {
            Human human = new Human("Montana", "Antonio", 30);
            Console.WriteLine(human);
            Console.WriteLine(delimiter); 
            Student student = new Student("Pinkman ", "Jessy ", 25, " Chemistry", " WW_220 ", 90 , 99);
            Console.WriteLine(student);
        }
    }
}
