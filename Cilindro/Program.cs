using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Write the height of the cylinder: ");
            string str = Console.ReadLine();
            float h = float.Parse(str);
            Console.Write("Write the radius of the cylinder: ");
            string sri = Console.ReadLine();
            float r = float.Parse(sri);
            double p = Math.PI;
            {
                Console.Write("The volume of the cylinder is ");
                Console.WriteLine(p * Math.Pow(r, 2) * h);
                Console.Write("The area of the cylinder is ");
                Console.WriteLine(2 * p * r * (r + h));

            }
        }
    }
}
