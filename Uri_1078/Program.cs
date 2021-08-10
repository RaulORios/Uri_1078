using System;

namespace Uri_1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int tabuada = i * n;
                Console.WriteLine($"{i} x {n} = {tabuada}");
            }
        }
    }
}
