using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public Person(string name)
            {
                Name = name;
            }
            ~Person()
            {
                Name = string.Empty;
            }
            public override string ToString()
            {
                return $"Person Name: {Name}";
            }
        }
            }
        }
  

