using System;
using System.Collections.Generic;

namespace Last3NumbersModulo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> Numbers = FirstGen();

            while (!Check(Numbers))
            {
                Numbers.Add(rnd.Next(10, 20));
            }
            // Pod spodem printuje ostatnie 3 liczby z Listy, ktore sa podzielne przez 3
            Console.WriteLine("Ostatnie 3 liczby podzielne przez 3:");
            for (int i = Numbers.Count - 1; i >= Numbers.Count - 3; i--)
            {
                Console.WriteLine($"{Numbers[i]}, ");
            }

            // ponizej printuje wszystkie elementy listy
            Console.WriteLine();
            foreach (var number in Numbers) Console.Write($"{number}, ");
        }
        static List<int> FirstGen()
        {
            List<int> Numbers = new List<int>();
            Random rnd = new Random();
            int rnd1, rnd2, rnd3;
            rnd1 = rnd.Next(10, 20);
            rnd2 = rnd.Next(10, 20);
            rnd3 = rnd.Next(10, 20);
            Numbers.Add(rnd1);
            Numbers.Add(rnd2);
            Numbers.Add(rnd3);
            return Numbers;
        }
        static bool Check(List<int> Numbers)
        {
            Random rnd = new Random();
            int index1 = Numbers.Count - 1;
            int index2 = Numbers.Count - 2;
            int index3 = Numbers.Count - 3;
            if (Numbers[index1] % 3 == 0 && Numbers[index2] % 3 == 0 && Numbers[index3] % 3 == 0)
            {
                return true;
            }
            else return false;
        }


    }
}
