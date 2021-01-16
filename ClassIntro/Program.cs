using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.KursEgitmrni = "engin";
            kurs1.IzlenmeOrani = 50;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c++";
            kurs2.KursEgitmrni = "yusuf";
            kurs2.IzlenmeOrani = 60;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "c";
            kurs3.KursEgitmrni = "berat";
            kurs3.IzlenmeOrani = 70;


            //Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            List<Kurs> kurslar = new List<Kurs>{kurs1,kurs2,kurs3 };


            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "phyton";
            kurs4.KursEgitmrni = "kadir";
            kurs4.IzlenmeOrani = 90;

            kurslar.Add(kurs4);


            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" "+kurs.KursEgitmrni+" "+kurs.IzlenmeOrani);
            }




           


            Console.ReadLine();
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmrni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
