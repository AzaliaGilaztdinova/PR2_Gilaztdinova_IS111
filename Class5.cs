using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _5.Program;

namespace _5
{
    internal class Class1
    {
        public abstract class Log
        {
            public abstract void Debug(string message);
            public abstract void Info(string message);
            public abstract void Warn(string message);
            public abstract void Error(string message);
            public abstract void Crit(string message);
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                ConsoleLog logger = new ConsoleLog();

                logger.Debug("Debug message");
                logger.Info("Info message");
                logger.Warn("Warning message");
                logger.Error("Error message");
                logger.Crit("Critical message");
            }
        }
    }
}

