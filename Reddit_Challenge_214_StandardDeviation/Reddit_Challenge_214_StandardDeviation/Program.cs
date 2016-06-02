using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reddit_Challenge_214_StandardDeviation
{
    class Program
    {
        //Program that calculate the standard deviation of a collection of numbers
        static void Main(string[] args)
        {
            //Prompts user for total numbers to enter
            Console.Write("Enter amount of numbers: ");
            string input = Console.ReadLine();
            int arrayLength = 0;
            bool test = Int32.TryParse(input, out arrayLength);
            while (test == false)
            {
                Console.Write("Enter amount of numbers: ");
                input = Console.ReadLine();
                arrayLength = 0;
                test = Int32.TryParse(input, out arrayLength);
            }

            int[] numbers = new int[arrayLength];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number: ");
                input = Console.ReadLine();
                int num = 0;
                test = Int32.TryParse(input, out num);
                while (test == false)
                {
                    Console.Write("Enter number: ");
                    input = Console.ReadLine();
                    num = 0;
                    test = Int32.TryParse(input, out num);
                }
                numbers[i] = num;
            }

            //Cycle through the array, totalling the sum
            //int[] numbers = new int[10] { 5, 6, 11, 13, 19, 20, 25, 26, 28, 37 };
            int meanSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                meanSum += numbers[i];
            }

            //Set array length and calculate mean
            int mean = meanSum / arrayLength;

            //Subtract mean from each number and square them, sum the numbers
            double sqrSum = 0;
            double tempSum = 0;
            int temp = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                temp += numbers[i];
                tempSum = (temp - mean);
                tempSum = Math.Pow(tempSum, 2);
                sqrSum = sqrSum + tempSum;
                temp = 0;
            }

            //Calculate variance and standard deviation
            double variance;
            variance = sqrSum / numbers.Length;

            double StandardDeviation;
            StandardDeviation = Math.Sqrt(variance);
            StandardDeviation = Math.Round(StandardDeviation, 4);

            //Print to screen
            Console.WriteLine("");
            Console.WriteLine("Mean: " + mean);
            Console.WriteLine("Standard Deviation: " +StandardDeviation);
        }
    }
}
