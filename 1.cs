using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._11._23
{
    internal class Program
    {
      
            public interface IMoney
        {
            int Rubli { get; set; }
            int Kopeyki { get; set; }
            void Print();
        }
        public class Money : IMoney
        {
            public int Rubli { get; set; }
            public int Kopeyki { get; set; }
            public void Print()
            {
                Console.WriteLine("{0} руб. {1} коп.", Rubli, Kopeyki);
            }
        }
        public interface IGood
        {
            IMoney Price { get; set; }
            void DecreasePrice(int percent);
        }
        public class Good : IGood
        {
            public IMoney Price { get; set; }
            public void DecreasePrice(int percent)
            {
                double decreasePercent = percent / 100.0;
                int decreaseAmount = (int)(Price.Rubli * decreasePercent);
                Price.Rubli -= decreaseAmount;
            }
        }
       
        }
    }

    

