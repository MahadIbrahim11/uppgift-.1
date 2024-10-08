using System;

namespace uppgift_1._1
{
    class Progam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många dagar vill du hyra bilen");
            int x = int.Parse(Console.ReadLine());
            int antaldagar = (x * 500) - 500;
            int dagsum = 300 + antaldagar;

            Console.WriteLine("hur många km ska du köra?");
            int km = int.Parse(Console.ReadLine());
            int kilometer = km * 1;
            int sum = kilometer + dagsum;

            Console.WriteLine("summan är" + sum + "kronor");


        }


    }



}