using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_CS
{
    internal class Human
    {
        //string lastName;
        //string firstName;
        //int age;
        public string LastName{ get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Human(string lastName, string firstName, int age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Console.WriteLine($"HConstructor:\t{ this.GetHashCode()}");
        }
        ~Human()
        {
            Console.WriteLine($"HDestructor:\t{this.GetHashCode()}");
        }
        public override string ToString()
        {
            return $"{LastName} {FirstName} {Age}";
        }
    }
}
