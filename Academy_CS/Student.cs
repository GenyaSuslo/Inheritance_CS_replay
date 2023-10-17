﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_CS
{
    internal class Student : Human
    {
        public string Speciality { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }
        public Student
            (
            string lastName, string firstName, int age,
            string speciality, string group, double rating, double attendance
            ):base(lastName,firstName,age)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SConstructor\t{this.GetHashCode()}");
        }
        ~Student()
        {
            Console.WriteLine($"SDestructor:\t{this.GetHashCode()}");
        }
        public override string ToString()//вывод
        {
            return base.ToString() +" " + $"{Speciality} {Group} {Rating} {Attendance}";
        }
    }
}
