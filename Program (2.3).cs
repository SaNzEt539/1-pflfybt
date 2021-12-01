using System;

namespace _2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("For: ");
            for (int i = A; i <= B; ++i)
                if (i < 0)
                    Console.WriteLine(i);

            Console.WriteLine("While: ");
            int counter = A;
            while (counter <= B)
            {
                if ((counter < 0))
                    Console.WriteLine(counter);
                ++counter;
            }

            Console.WriteLine("do while: ");
            counter = A;
            do
            {
                if ((counter < 0))
                    Console.WriteLine(counter);
                ++counter;
            }
            while (counter <= B);

            Console.ReadKey();
        }
    }
}
