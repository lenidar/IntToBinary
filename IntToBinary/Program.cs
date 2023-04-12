using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> bits = new Stack<int>();
            int bitGroup = 4;
            int dispCount = 0;

            int numToConvert = 0;
            Random rnd = new Random();

            numToConvert = rnd.Next(1000);

            Console.Write(numToConvert + " in binary is ");

            while (numToConvert > 0)
            {
                if (numToConvert % 2 == 1)
                {
                    bits.Push(1);
                    numToConvert--;
                }
                else
                    bits.Push(0);

                numToConvert = numToConvert / 2;
            }

            while(bits.Count % bitGroup != 0)
                bits.Push(0);

            while (bits.Count() > 0) 
            {
                Console.Write(bits.Pop());
                dispCount++;

                if(dispCount == 4)
                {
                    Console.Write(" ");
                    dispCount = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
