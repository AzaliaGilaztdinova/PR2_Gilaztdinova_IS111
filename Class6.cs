using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _6.Program;

namespace _6
{
    internal class Class1
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Console.Write("Enter the name of the dog: ");
                string dogName = Console.ReadLine();

                Dog dog = new Dog();
                dog.SetName(dogName);

                Console.WriteLine($"Dog name: {dog.GetName()}");
                dog.Eat();
            }
        }
    }
}
