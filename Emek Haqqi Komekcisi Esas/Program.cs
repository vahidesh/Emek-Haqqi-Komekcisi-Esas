using System;

namespace Emek_Haqqi_Komekcisi_Esas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Umumi emek haqqini daxil edin: ");
            int x = int.Parse(Console.ReadLine()); //umum emek haqqi
            Console.WriteLine("Aile veziyyetiniz - e(evli),s(subay),d(dul)!");
            string y = Console.ReadLine();//aile veziyyeti


            int u = 0;//usaq sayi
            double gs = 0;//gross
            double v = 0;//vergi meblegi
            string f = "";//fiziki qusur
            int i = 0;//usaq pulu
            int aile = 0;//aile muavinati
            double j = 0;//vergi dercesi


            if (y == "d")
            {
                Console.WriteLine("Usaq var? b(beli), x(xeyr)");
                string p = Console.ReadLine();
                if (p == "b")
                {
                    Console.WriteLine("Usaq sayini daxil et: ");
                    u = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Fiziki qusurunuz var? b(beli), x(xeyr)");
                f = Console.ReadLine();

            }

            else if (y == "e")
            {
                Console.WriteLine("Usaqiniz var? b(beli), x(xeyr)");
                string p = Console.ReadLine();
                if (p == "b")
                {
                    Console.WriteLine("Usaq sayini daxil edin: ");
                    u = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Fiziki qusurunuz var? b(beli), x(xeyr)");
                f = Console.ReadLine();

            }
            if (y == "s")
            {
                Console.WriteLine("Fiziki qusurunuz var? b(beli), x(xeyr)");
                f = Console.ReadLine();

            }
            if (y == "e")
            {
                aile = 50;
                gs = x + aile;
            }
            else
            {
                aile = 0;
                gs = x + aile;
            }
            if (u == 1)
            {
                i = 30;
                gs = gs + i;
            }
            else if (u == 2)
            {
                i = 55;
                gs = gs + i;
            }
            else if (u == 3)
            {
                i = 75;
                gs = gs + i;
            }
            else if (u > 3)
            {
                i = 75 + 15 * (u - 3);
                gs = gs + i;
            }

            if (x <= 1000)
            {
                j = 15.00 / 100.00;
                v = gs * j;
            }
            else if (x < 2000 && x > 1000)
            {
                j = 20.00 / 100.00;
                v = gs * j;
            }
            else if (x >= 2000 && x < 3000)
            {
                j = 25.00 / 100.00;
                v = gs * j;
            }
            else if (x >= 3000)

            {
                j = 30.00 / 100.00;
                v = gs * j;
            }
            if (f == "b")
            {
                v = v * 50 / 100;
            }
            gs = gs - v;

            Console.WriteLine($"Aile muavinati-{aile.ToString("0.00")} ");
            Console.WriteLine($"Usaq pulu-{i.ToString("0.00")}");
            Console.WriteLine($"Vergi meblegi-{v.ToString("0.00")}");
            Console.WriteLine($"Vergi derecesi-{j.ToString("0.00")}");
            Console.WriteLine($"Umumi emek haqqi-{x.ToString("0.00")}");
            Console.WriteLine($"Xalis emek haqqi-{gs.ToString("0.00")}");



            int range = (int)Math.Floor(gs / 200);
            int range1 = (int)Math.Floor((gs - range * 200) / 100);
            int range2 = (int)Math.Floor(((gs - range * 200) - range1 * 100) / 50);
            int range3 = (int)Math.Floor((((gs - range * 200) - range1 * 100) - range2 * 50) / 20);
            int range4 = (int)Math.Floor(((((gs - range * 200) - range1 * 100) - range2 * 50) - range3 * 20) / 10);
            int range5 = (int)Math.Floor((((((gs - range * 200) - range1 * 100) - range2 * 50) - range3 * 20) - range4 * 10) / 5);
            int range6 = (int)Math.Floor(((((((gs - range * 200) - range1 * 100) - range2 * 50) - range3 * 20) - range4 * 10) - range5 * 5) / 1);

            Console.WriteLine(range + "x 200");
            Console.WriteLine(range1 + "x 100");
            Console.WriteLine(range2 + "x 50");
            Console.WriteLine(range3 + "x 20");
            Console.WriteLine(range4 + "x 10");
            Console.WriteLine(range5 + "x 5");
            Console.WriteLine(range6 + "x 1");

        }
    }
}