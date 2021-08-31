using System;

namespace name
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fornavne = { "Ib", "Kim", "Helle", "Jens", "Ove" };
            foreach (string skuffe in fornavne)
            {
                Console.WriteLine(skuffe);
            }
            Console.ReadLine();
            string[] efternavne = { "Jensen", "Nielsen", "Larsen" };
            foreach (string kasse in efternavne)
            {
                //Console.WriteLine(kasse);
                foreach (string skuffe in fornavne)
                {
                    Console.WriteLine(skuffe + " " + kasse);
                }
            }
            Console.WriteLine("Indtast 3 efternavn");
            efternavne[0] = Console.ReadLine();
            efternavne[1] = Console.ReadLine();
            efternavne[2] = Console.ReadLine();
            /*
                foreach (string skuffe in efternavne)
            {
                Console.WriteLine(skuffe);
            }
            */
            foreach (string kasse in efternavne)
            {
                //Console.WriteLine(kasse);
                foreach (string skuffe in fornavne)
                {
                    Console.WriteLine(skuffe + " " + kasse);
                }
            }

            Console.ReadLine();
                }
           }
}
