namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random _Random = new Random();
            int Num = _Random.Next(1, 10);
            int Guess = 0;
            Console.Write("num: ");

            while (true)
            {
                Guess = Convert.ToInt32(Console.ReadLine());
                if (Guess < Num)
                {
                    Console.WriteLine("num low");
                } else if (Guess > Num)
                {
                    Console.WriteLine("num high");
                } else
                {
                    Console.WriteLine("correct");
                    Console.Write("continue y/n: ");
                    string Choice = Console.ReadLine();
                    if (Choice == "y") { continue; } else { break; }
                }
            }
        }
    }
}
