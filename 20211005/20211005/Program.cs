using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211005
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat21();
            //feladat22();
            //feladat23();
            //feladat24();
            feladat25();
            Console.WriteLine("Nyomd le az entert!");
            Console.ReadLine();

        }
        static void feladat21()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 15; j++)
                {

                }
            }
        }
        static void feladat22()
        {
            int a = 2;
            int b = 3;
            int c = 5;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("a={0} b={1} c={2} V={3}", a, b, c, a * b * c);
                a = a + 1;
                b = b + 2;
                c = c + 3;
            }

        }
        static void feladat23()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Felszín = {0} ", i * i);
                i = i + 2;
            }
        }
        static void feladat24()
        {
            Console.WriteLine("Írj be egy számot!");
            int a = int.Parse(Console.ReadLine());
            while (a!=0)
            {
                Console.WriteLine("Írj be egy másik számot!");
                a = int.Parse(Console.ReadLine());
            }
        }
        static void feladat25()
        {
            
        }
    }
}
