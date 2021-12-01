using System;

namespace _2_2
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("n=");
            uint num = 0;
            if (uint.TryParse(Console.ReadLine(), out num))
            {
                if (num < 1)
                {
                    Console.WriteLine("Младенец");
                }
                if (1 < num && num < 11)
                {
                    Console.WriteLine("Ребёнок");
                }
                if (12 < num && num < 15)
                {
                    Console.WriteLine("Подросток");
                }
                if (16 < num && num < 25)
                {
                    Console.WriteLine("Юноша");
                }
                if (26 < num && num < 70)
                {
                    Console.WriteLine("Мужчина");
                }
                if (num > 70)
                {
                    Console.WriteLine("Пожилой человек");
                }
            }
            else
            {
                Console.WriteLine("Вы ошиблись");
            }
            Console.ReadKey();
        }
    }
}
