using System;
using System.IO;

namespace RandomNumberFileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers you wanna create?");
            int randomNumbersCounter = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the file name to save the random numbers:");
            string randomFile = Console.ReadLine();

            Random random = new Random();

            using (StreamWriter writer = new StreamWriter(randomFile))
            {
                for (int i = 0; i < randomNumbersCounter; i++)
                {
                    int randomNumber = random.Next(1, 101);
                    writer.WriteLine(randomNumber);
                }
            }

            Console.WriteLine("Success.. your file has been created with some random number!");
            Console.ReadLine();
        }
    }
}
