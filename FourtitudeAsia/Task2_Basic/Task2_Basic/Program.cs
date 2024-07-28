using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = "20191001187";
            int specialDigit = CalculateSpecialDigit(sequence);

            Console.WriteLine("\nThe special digit for the value {0} is {1}.\n", sequence, specialDigit);

            // Wait for user input before closing
            Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }

        static int CalculateSpecialDigit(string sequence)
        {
            int A = 0, B = 0, C = 0, D = 0, E = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                int digit = int.Parse(sequence[i].ToString());

                if (i % 5 == 0)
                    A += digit * 10;
                else if (i % 5 == 1)
                    B += digit * 8;
                else if (i % 5 == 2)
                    C += digit * 6;
                else if (i % 5 == 3)
                    D += digit * 4;
                else if (i % 5 == 4)
                    E += digit * 2;
            }

            int totalSum = A + B + C + D + E;
            int specialDigit = ReduceToSingleDigit(totalSum);

            return specialDigit;
        }

        static int ReduceToSingleDigit(int number)
        {
            while (number >= 10)
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                number = sum;
            }
            return number;
        }
    }
}
