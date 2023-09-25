using System;

namespace TotalScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            if (!int.TryParse(Console.ReadLine(), out int length) || length <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    return;
                }
            }

            int totalScore = CalculateTotalScore(numbers);
            Console.WriteLine($"Total Score: {totalScore}");
        }

        static int CalculateTotalScore(int[] numbers)
        {
            int score = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    // 1 point for each even number
                    score += 1;
                }
                else
                {
                    // 3 points for each odd number
                    score += 3;
                }

                if (number == 8)
                {
                    // 5 points for each occurrence of 8
                    score += 5;
                }
            }

            return score;
        }
    }
}
