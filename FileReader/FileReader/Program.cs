using System;
using System.IO;

namespace RandomNumberFileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path of the file to read:");
            string filePath = Console.ReadLine();

            ReadRandomNumbersFromFile(filePath);
        }

        static void ReadRandomNumbersFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                int totalNumbers = 0;
                int sum = 0;

                foreach (string line in lines)
                {
                    if (int.TryParse(line, out int number))
                    {
                        Console.WriteLine(number);
                        totalNumbers++;
                        sum += number;
                    }
                }

                Console.WriteLine("Total Numbers: " + totalNumbers);
                Console.WriteLine("Sum: " + sum);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }
    }
}
