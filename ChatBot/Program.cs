using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Happy World! I am god, ask me anything. (Also you can write EXIT to leave)");
            bool y = true;
            while (y == true) 
            {
                String x = Console.ReadLine();
                if (x == "Who's the best bandori girl?")
                    {
                        Console.WriteLine("Misaki.");
                    }
                else if (x == "What's the best bandori song?")
                    {
                    Console.WriteLine("Roselia cover of Charles.");
                    }
                else if(x == "Gay?")
                    {
                    Console.WriteLine("Yes.");
                    }
                else if(x == "What's the worst band?")
                    {
                    Console.WriteLine("RAS.");
                    }
                else if(x == "EXIT")
                    {
                    Console.WriteLine("Goodbye...");
                    y = false;
                    }
                else
                    {
                    Console.WriteLine("Who?");
                    }
            }
        }
    }
}
