using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_İkinci_Dereceden_Denklem_Cozme
{
    class Program
    {
        public static void başlık()
        {
            Console.Clear();

            Console.WriteLine("                                  ***********");
            Console.WriteLine("                                  *KÖK BULMA*");
            Console.WriteLine("                                  ***********");

        }

        static void Main(string[] args)
        {
        
        git:

            string d, t;
            int q;
            double k, x1, x2;
            double x, y, z;

            başlık();

            for (q = 0; q < 4; q++)
                Console.WriteLine();


            Console.WriteLine(@"                             AÇIKLAMA         A/a

                             İŞLEM YAP        E/e");


            d = Console.ReadLine();

            { 

                if (d == "A" || d == "a")
                {
                    başlık();

                    for (q = 0; q < 4; q++)
                        Console.WriteLine();

                    Console.WriteLine(@"Program 2 bilinmeyenli bir denklemin köklerini bulmak için hazırlanmıştır.
Denklemin formatı ax^2+bx+c şeklinde olduğu düşünüp köklerini bulmak
istediğimiz denklemin aynı sıra ile a,b,c değerlerini giriniz.");

                    for (q = 0; q < 4; q++)
                        Console.WriteLine();

                    Console.WriteLine("                         ANA SAYFA                    A/a");
                    t = Console.ReadLine();

                    if (t == "A" || t == "a")
                    {
                        Console.Clear();
                        goto git;
                    }


                }

                else if (d == "E" || d == "e")
                { 

                    başlık();

                    for (q = 0; q < 4; q++)
                        Console.WriteLine();

                    Console.Write("                     a değerini giriniz=");
                    x = double.Parse(Console.ReadLine());

                    Console.Write("                     b değerini giriniz=");
                    y = double.Parse(Console.ReadLine());

                    Console.Write("                     c değerini giriniz=");
                    z = double.Parse(Console.ReadLine());

                    k = (y * y) - 4 * x * z;

                    if (k < 0)
                    {
                        başlık();

                        for (q = 0; q < 4; q++)
                            Console.WriteLine();

                        Console.WriteLine("                         DENKLEMİN REEL KÖKÜ YOKTUR");

                    }

                    else if (k > 0)
                    {
                        başlık();

                        for (q = 0; q < 4; q++)
                            Console.WriteLine();

                        Console.WriteLine("                         DENKLEMİN 2 REEL KÖKÜ VARDIR");

                        for (q = 0; q < 2; q++)
                            Console.WriteLine();

                        x1 = (-y) + Math.Sqrt(k) / (2 * x);

                        x2 = (-y) - Math.Sqrt(k) / (2 * x);

                        Console.WriteLine("                             Birinci Kök=" + x1);
                        Console.WriteLine();
                        Console.WriteLine("                             İkinci Kök=" + x2);

                    }

                    else
                    {
                        başlık();

                        for (q = 0; q < 4; q++)
                            Console.WriteLine();

                        Console.WriteLine("                         DENKLEMİN EŞİT 2 KÖKÜ VARDIR");

                        for (q = 0; q < 2; q++)
                            Console.WriteLine();

                        x1 = -y / (2 * x);

                        Console.WriteLine("                             Kök=" + x1);

                    } 

                } 
            }

            Console.ReadKey();
        }
    }
}
