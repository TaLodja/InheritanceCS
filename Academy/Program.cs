//#define CLASS_CHECK
//#define TO_CONSOLE
//#define WRITE_TO_FILE
#define READ_FROM_FILE
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if CLASS_CHECK
            Human human = new Human("Schwartznegger", "Arnold", 78);
            Console.WriteLine(human);

            Student student = new Student("Colombo", "Franco", 91, "HeavyMetal", "LA", 98, 100);
            Console.WriteLine(student);

            Teacher teacher = new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20);
            Console.WriteLine(teacher);

            Graduate graduate = new Graduate("Schreder", "Hank", 40, "Criminalistic", "WW_220", 40, 60, "How to catch Heisenberg");
            Console.WriteLine(graduate); 
#endif
#if TO_CONSOLE
            Human[] group = new Human[]
               {
                new Human("Schwartznegger", "Arnold", 78),
                new Student("Colombo", "Franco", 91, "HeavyMetal", "LA", 98, 100),
                new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20),
                new Graduate("Schreder", "Hank", 40, "Criminalistic", "WW_220", 40, 60, "How to catch Heisenberg"),
                new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 99)
               };
            FileWork.Print(group);
#endif
#if WRITE_TO_FILE
            Human[] group = new Human[]
                   {
                new Human("Schwartznegger", "Arnold", 78),
                new Student("Colombo", "Franco", 91, "HeavyMetal", "LA", 98, 100),
                new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20),
                new Graduate("Schreder", "Hank", 40, "Criminalistic", "WW_220", 40, 60, "How to catch Heisenberg"),
                new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 99)
                   };
            FileWork.PrintToFile(group, @"C:\\Users\\Владелец\\source\\repos\\InheritanceCS\\Academy\\group1.txt");
#endif
#if READ_FROM_FILE
            Human[] group = FileWork.ReadFromFile(@"C:\Users\Владелец\source\repos\InheritanceCS\Academy\group1.txt");
            FileWork.Print(group);
#endif
        }
    }
}
