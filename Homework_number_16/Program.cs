using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maximumRandomNumber = 27;
            int minimalRandomNumber = 1; 
            int randomNumber = random.Next(minimalRandomNumber, maximumRandomNumber);
            int startIndex = 100;
            int endIndex = 1000;
            int numberOfMultiples = 0;
            int remainder;

            for (int i = startIndex; i < endIndex; i++)
            {
                remainder = i;
                
                while (remainder >0)
                {
                    remainder -= randomNumber;

                    if (remainder == 0)
                    {
                        numberOfMultiples++;
                    }
                }
            }
        }
    }
}
