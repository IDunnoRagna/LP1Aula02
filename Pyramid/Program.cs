using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, l;
            Console.Write("Input number of lines of the pyramid :");
            //Total number of lines
            l = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= l; i++) //The number of the current line that is being drawn and it cannot be higher than the total
            {
                for (j = 1; j <= l - i; j++) //The number of spaces is the total number of lines - the current line
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1 ; j++) //The number of asterisks twice the number of the current like - 1
                    Console.Write("*");
                Console.Write("\n"); //This makes it so that the next time we go throgh the loop, we'll be on the next line display wise
                
            }
        }
    }
}
