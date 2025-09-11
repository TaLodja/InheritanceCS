//#define CLASS_CHECK
//#define TO_CONSOLE
//#define WRITE_TO_FILE
using System;
using System.Collections.Generic;
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
            foreach (Human i in group)
            {
                Console.WriteLine(i);
            }
            /*for (int i = 0; i < group.Length; i++)
            {
                Console.WriteLine(group[i]);
            } */
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
            string path = @"C:\Users\Владелец\source\repos\InheritanceCS\Academy\group.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (Human i in group)
                {
                    sw.WriteLine(i.ToString());
                }
            } 
#endif

        }
    }
}
