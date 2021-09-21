using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210921
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            feladat4();

            Console.WriteLine("Nyomd le az entert.");
            Console.ReadLine();
        }
        static void feladat1()
        {
            Console.WriteLine("Kérek egy számot!");
            int szam = int.Parse(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("A szám páros.");
            }
            else
            {
                Console.WriteLine("A szám páratlan.");
            }
            Console.ReadKey();
        }
        static void feladat2()
        {

        }
        static void feladat3()
        {
            Console.WriteLine("Add meg a kinti hőmérsékletet");
            int homerseklet = int.Parse(Console.ReadLine());
            if (homerseklet >= 0)
            {
                Console.WriteLine("Nincs fagypont alatt a hőmérséklet.");
            }
            else
            {
                Console.WriteLine("Fagypont alatt van a hőmérséklet.");
            }
            Console.ReadKey();
        }
        static void feladat4()
        {
            Console.WriteLine("Add meg a számot!");
            int kozott = int.Parse(Console.ReadLine());
            if (-30 <=kozott  && kozott<= 40)
            {
                Console.WriteLine("A szám köztük van.");
            }
            else
            {
                Console.WriteLine("A szám nincs közöttük.");
            }
            Console.ReadKey();
        }
    }
}
