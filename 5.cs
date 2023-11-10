using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        public class ConsoleLog : Class1.Log
        {
            public override void Debug(string message)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"[DEBUG] {message}");
                Console.ResetColor();
            }

            public override void Info(string message)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[INFO] {message}");
                Console.ResetColor();
            }

            public override void Warn(string message)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[WARN] {message}");
                Console.ResetColor();
            }

            public override void Error(string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ERROR] {message}");
                Console.ResetColor();
            }

            public override void Crit(string message)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"[CRITICAL] {message}");
                Console.ResetColor();
            }
        }
        }
    }

