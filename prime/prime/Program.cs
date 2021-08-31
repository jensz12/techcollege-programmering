using System;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primtal = { 1, 2, 3, 5, 7, 11, 13, 17, 23 };
            Console.WriteLine("indtast et tal imellem 1 og 9");
            string indeks = Console.ReadLine();
            int arridx = Convert.ToInt32(indeks) - 1;

            Console.WriteLine("primtal nummer " + indeks + " er: " + primtal[arridx]);

            Console.ReadLine();

        }
    }
}