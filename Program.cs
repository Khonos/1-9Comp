using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_9_Arası_sayı_seçme_karşılaştırma_V._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int sayı1, sayı2;


            while (true)
            {
                Console.WriteLine("Please enter a first number between 1 and 9 (inclusive):");
                if (int.TryParse(Console.ReadLine(), out sayı1) && sayı1 >= 1 && sayı1 <= 9)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input for the first number. Please enter a valid number between 1 and 9.");
                }
            }

            while (true)
            {
                Console.WriteLine("Please enter a second number between 1 and 9 (inclusive):");
                if (int.TryParse(Console.ReadLine(), out sayı2) && sayı2 >= 1 && sayı2 <= 9)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number. Please enter a valid number between 1 and 9.");
                }
            }

            Console.WriteLine("The first number is: {0}", sayı1);
            Console.WriteLine("The second number is: {0}", sayı2);

            if (sayı1 > sayı2)
            {
                Console.WriteLine("Among these numbers, {0} is greater.", sayı1);
            }
            else if (sayı2 > sayı1)
            {
                Console.WriteLine("Among these numbers, {0} is greater.", sayı2);
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }

            Console.ReadLine();
        }
    }
}
