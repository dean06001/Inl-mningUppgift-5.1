using System;
namespace InlämningUppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 5 namn");

            string[] namn = new string[5];

            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine($"Skriv in namn {i + 1}");
                namn[i] = Console.ReadLine();
            }

            Console.WriteLine("Här är de namnen du skrev in");

            foreach (string ord in namn)
            {
                Console.WriteLine(ord);
            }
            Console.ReadLine();
        }
    }
}