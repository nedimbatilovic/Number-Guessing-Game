using System;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Program _program = new Program();
            _program.NumGuess();
        }

        public void NumGuess()
        {
            Random _Random = new();
            int Num = _Random.Next(1, 1000);
            while (true)
            {
                Console.Write("num: ");
                int Guess;
                bool resume = int.TryParse(Console.ReadLine(), out Guess);
                if (resume)
                {                        
                    if (Guess < Num)
                    {
                        Console.WriteLine($"{Guess} is too low.");
                    }
                    else if (Guess > Num)
                    {
                        Console.WriteLine($"{Guess} is too high.");
                    }
                    else
                    {
                        Console.WriteLine($"{Guess} is correct.{Environment.NewLine}");
                        Num = _Random.Next(1, 1000);
                        Console.Write("continue y/n: ");
                        string Choice = Console.ReadLine();
                        if (Choice == "n")
                        {
                            break;
                        }
                    }        
                } else
                {
                    Console.WriteLine("Guess must be an integer.");
                }
            }
        }
    }
}

