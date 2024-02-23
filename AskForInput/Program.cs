using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls  write an integer");
            string answer1 = Console.ReadLine();

            int i = int.Parse(answer1);
            Console.WriteLine($"this is in i:-> {i}");
            
            Console.WriteLine("Pls  write a real number");
            string answer2 = Console.ReadLine();

            float f = float.Parse(answer2);

            var result = i + f;
            Console.WriteLine($"Here's the result->{result}");

        }
    }
}
