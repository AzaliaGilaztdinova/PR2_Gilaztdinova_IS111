using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2.Program;

namespace _2
{
    internal class Class2
    {
        public static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop("dexp", 60000, "i3", 2, 500);
            Laptop laptop2 = new Laptop("asus", 80000, "i5", 4, 1024); Laptop laptop3 = new Laptop("huawei", 100000, "i9", 8, 1024);
            laptop1.Display(); laptop2.Display(); laptop3.Display();
        }
    }
}
