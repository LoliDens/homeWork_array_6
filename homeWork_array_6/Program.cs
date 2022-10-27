using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_array_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];
            int lowerLimitRandom = 0;
            int upperLimitRandom = 10;
            int minNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++) 
            {
                numbers[i] = random.Next(lowerLimitRandom,upperLimitRandom + 1);
            }

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.Write(numbers[i] + " ");
            }

            for (int i = 0; i < numbers.Length - 1; i++) 
            {
                for (int j = 1; j < numbers.Length; j++) 
                {
                    if (numbers[j - 1] > numbers[j]) 
                    {
                        minNumber = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = minNumber;
                    }
                }
            }

            Console.WriteLine("\nМассив отсортированный от большего элемента к меньшиму: ");

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.Write(numbers[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
