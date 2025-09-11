using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher: Human
    {
        public string Speciality { get; set; }
        public int Experience { get; set; }
        //Constructors
        public Teacher
            (
            string lastName, string firstName, int age,
            string speciality, int experiennce
            ): base(lastName, firstName, age)
        {
            Speciality = speciality;
            Experience = experiennce;
            Console.WriteLine($"TConstructor:\t{GetHashCode().ToString("X")}");
        }
        ~Teacher()
        {
            Console.WriteLine($"TDestructor:\t{GetHashCode().ToString("X")}");
        }
        public override string ToString()
        {
            return base.ToString()+$" {Speciality} {Experience}";
        }
    }
}
