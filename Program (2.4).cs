using System;

namespace _2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 8; i > 3; i--)
            {
                Write(i, 9 - i);
            }
            Console.ReadKey();
        }
        static void Write(int noumber, int countTime)
        {
            for (int i = 0; i < countTime; i++)
                Console.Write("{0} \t", noumber);
            Console.WriteLine();
        }
    }
}
