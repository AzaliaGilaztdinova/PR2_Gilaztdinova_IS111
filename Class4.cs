using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _4.Program;

namespace _4
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            Person[] people = new Person[3];

            for (int i = 0; i < people.Length; i++)
            {
                Console.Write($"Enter name for person {i + 1}: ");
                string name = Console.ReadLine();
                people[i] = new Person(name);
            }

            Console.WriteLine("People:");

            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}