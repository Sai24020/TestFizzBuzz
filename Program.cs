using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        while (true)
        {
            Console.WriteLine("Write three numbers separated by space (X Y N):");
            Console.WriteLine("Example: 2 3 7 || 2 4 7 || 3 5 7 \n" + Environment.NewLine + "This will print numbers from 1 to 7,\n \nreplacing multiples of 2 with 'Fizz', \nmultiples of 3 with 'Buzz', \nand multiples of both with 'FizzBuzz'.");

            Console.Write("\n Input: ");
            string? inputLine = Console.ReadLine();
            if (inputLine == null)
                continue;
            string[] input = inputLine.Split(' ');

            if (input.Length != 3)
            {
                Console.WriteLine("Error: You must write THREE numbers with spaces between them (example: 2 3 7).");
                continue;
            }

            int X = int.Parse(input[0]);
            int Y = int.Parse(input[1]);
            int N = int.Parse(input[2]);

            Console.WriteLine("Result:");

            for (int i = 1; i <= N; i++)
            {
                if (i % X == 0 && i % Y == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % X == 0)
                    Console.WriteLine("Fizz");
                else if (i % Y == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }

            Console.WriteLine("Do you want to try another input? (Y/N)");
            string? answer = Console.ReadLine();

            if (string.Equals(answer, "N", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}