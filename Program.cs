using System;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz");

            var fizzBuzz = new FizzBuzzMachine(new[]
            {
                new DivisorAndWord(3, "Fizz"),
                new DivisorAndWord(5, "Buzz"),
                new DivisorAndWord(7, "Bang")
            });
            for (int i = 1; i < 500; i++)
            {
                var result = fizzBuzz.Say(i);
                Print(result);
            }
        }

        static void Print(string result)
        {
            Console.ForegroundColor = Color(result);
            Console.Write($"{result} ");
            Console.ResetColor();
        }

        static ConsoleColor Color(string text)
        {
            var length = text.Length;
            if (length == 4) return ConsoleColor.DarkGreen;
            if (length == 8) return ConsoleColor.DarkCyan;
            if (length == 12) return ConsoleColor.DarkMagenta;

            return ConsoleColor.White;
        }
    }
}