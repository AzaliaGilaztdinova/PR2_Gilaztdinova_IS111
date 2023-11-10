using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
       
        public class Laptop
        {
            private string name; private int price; private string processor; private int ram;
            private int hardDisk; public Laptop(string name, int price, string processor, int ram, int hardDisk)
            {
                this.name = name; this.price = price;
                this.processor = processor; this.ram = ram; this.hardDisk = hardDisk;
            }
            public void Display()
            {
                Console.WriteLine("Ноутбук:");
                Console.WriteLine($"Название: {name}"); Console.WriteLine($"Цена: {price} рублей"); Console.WriteLine($"Процессор: {processor}"); Console.WriteLine($"Оперативная память: {ram} ГБ");
                Console.WriteLine($"Жесткий диск: {hardDisk} ГБ"); Console.WriteLine();
            }
        }
        }                   
    }

