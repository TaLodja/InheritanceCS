using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Student: Human
    {
        public string Speciality { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }
        //Constructors:
        public Student
            (
            string lastName, string firstName, int age,
            string speciality, string group, double rating, double attendance
            ):base(lastName, firstName, age)
        {
            Speciality = speciality; ;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SConstructor:\t{GetHashCode().ToString("X")}");
        }
        ~Student()
        {
            Console.WriteLine($"SDestructor:\t{GetHashCode().ToString("X")}");
        }
        public override string ToString()
        {
            return base.ToString()+$" {Speciality} {Group} {Rating} {Attendance}";
        }
        public override string ToStringInFile()
        {
            return base.ToStringInFile() + $",{Speciality},{Group},{Rating},{Attendance}";
        }
        public override Human Init(string[] parameters)
        {
            base.Init(parameters);
            Speciality = parameters[4];
            Group = parameters[5];
            Rating = Convert.ToDouble(parameters[6]);
            Attendance = Convert.ToDouble(parameters[7]);
            return this;
        }
    }
}
