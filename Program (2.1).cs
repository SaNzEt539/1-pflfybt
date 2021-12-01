using System;

namespace _2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("y: ");
            y = double.Parse(Console.ReadLine());

            if ((x * x + y * y < 144) && y < x)
            {
                Console.Write("Да");
            }

            else if ((x * x + y * y == 144) || y == x)
            {
                Console.Write("На границе");
            }

            else 
            {
                Console.Write("Нет");
            }
            Console.ReadLine();
        }
    }
}
