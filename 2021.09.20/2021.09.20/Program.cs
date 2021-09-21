using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021._09._20
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            //feladat5();
            //feladat6();
            feladat7();

            Console.WriteLine("Nyomd le az entert!");
            Console.ReadLine();

        }
        static void feladat1()
        {
            Console.WriteLine("Hello world!");
        }
        static void feladat2()
        {
            Console.WriteLine("Írd le a neved!");
            string nev = Console.ReadLine();
            Console.WriteLine("Hello {0}", nev);

            Console.ReadKey();
        }
        static void feladat3()
        {
            Console.WriteLine("Írd le a neved!");
            string koszones = Console.ReadLine();
            int szelesseg = Console.WindowWidth;
            int magassag = Console.WindowHeight;
            int x = szelesseg / 2 - koszones.Length / 2;
            int y = magassag / 2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(koszones);
            Console.ReadKey();
        }
        static void feladat4()
        {
            Console.WriteLine("Írj be egy számot.");
            Console.WriteLine("A szám kétszerese:{0}", int.Parse(Console.ReadLine())*2);
            Console.ReadKey();
        }
        static void feladat5()
        {
            Console.WriteLine("Kérek egy számot!");
            int szamok =int.Parse( Console.ReadLine());
            Console.WriteLine("Kérek egy másik számot!");
            int masikszam =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(szamok + masikszam);
            Console.WriteLine(szamok - masikszam);
            Console.WriteLine(szamok * masikszam);
            Console.WriteLine(szamok / masikszam);
        }
        static void feladat6()
        {
            Console.WriteLine("Add meg a négyzet oldalát!");
            int negyzet = int.Parse(Console.ReadLine());
            Console.WriteLine("A négyzet kerülete: {0}", negyzet * 4);
            Console.WriteLine("A négyzet területe: {0}", negyzet * negyzet);
        }
        static void feladat7()
        {
            Console.WriteLine("Add meg az a oldalt!");
            int aoldal = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a b oldalt!");
            int boldal = int.Parse(Console.ReadLine());
            Console.WriteLine("A téglalap kerülete {0}", aoldal * 2+boldal);
            Console.WriteLine("A téglalap területe {0}", aoldal * boldal);
        }
    }
}
