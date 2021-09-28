using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210827
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat6();
            //feladat4();
            //feladat5();
            //feladat7();
            //feladat8();
            //feladat9();
            feladat10();
            Console.WriteLine("Nyomd le az entert!");
            Console.ReadLine();
        }
        static void feladat1()
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(i + " "); //konkatenáció
            }
            Console.WriteLine();
            for (int i = 0; i <= 20; i++)
            {
                Console.Write("{0} ", i); //paraméteresen
            }
            Console.WriteLine();
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(i); //barbár
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        static void feladat2()
        {
            for (int i = 15; i <= 92; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
        static void feladat3()
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine("{0} ", i);
                }
                Console.WriteLine();
                
            }
        }
        static void feladat6()
        {
            int cv = 1;
            while (cv<16)
            {
                Console.WriteLine("{0} ", cv*cv);
                cv++;

            }
            Console.WriteLine();
            
        }
        static void feladat4()
        {
            Console.WriteLine("Adj meg egy számot!");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("{0} ", i);
            }
        }
        static void feladat5()
        {
            Console.WriteLine("Adj meg egy számot!");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("{0} ", i);
            }
        }
        static void feladat7()
        {
            
            int i = 100;
            while (i < 401)
            {
                if (i  % 4 == 0)
                {
                    Console.Write("{0} ", i);
                }
                i++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static void feladat8()
        {
            for (int i = 30; i < 100; i= i+9)
            {


                Console.Write("{0} ", i);
                 
                
                
                
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static void feladat9()
        {
            for (int i = 150; i > 40; i= i- 12)
            {
                Console.Write("{0} ", i);
            }
            Console.ReadKey();
        }
        static void feladat10()
        {
            int i = 100;
            while (i>-100)
            {
                if (i%9==0)
                {
                    Console.Write("{0} ", i);
                }
                i++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
