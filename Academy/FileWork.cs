using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class FileWork
    {
        internal static void Print(Human[] group)
        {
            foreach (Human i in group)
            {
                Console.WriteLine(i);
            }
        }
        internal static void PrintToFile(Human[] group, string filename)
        {
            string path = filename;
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (Human i in group)
                {
                    sw.WriteLine(i.ToStringInFile());
                }
            }
        }
        internal static Human[] ReadFromFile(string fileName)
        {
            string buffer;
            int n = 0;
            using (StreamReader sr = new StreamReader(fileName))
            {
                while ((buffer = sr.ReadLine()) != null)
                {
                    n++;
                }
                Console.WriteLine(n);
            }
            Human[] group = new Human[n];
            using (StreamReader sr = new StreamReader(fileName))
            {
                int i = 0;
                while ((buffer = sr.ReadLine()) != null)
                {
                    string[] parameters = buffer.Split(',');
                    group[i] = HumanFactory.Create(parameters[0]).Init(parameters);
                    i++;
                }
            }
            return group;
        }
    }
}
