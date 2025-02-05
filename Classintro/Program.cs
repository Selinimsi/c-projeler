using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursunAdı = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 47;


            Kurs kurs2 = new Kurs();
            kurs2.KursunAdı = "phyton";
            kurs2.Eğitmen = "Engin Demiroğ";
            kurs2.IzlenmeOranı = 47;

            Kurs kurs3 = new Kurs();
            kurs3.KursunAdı = "C#";
            kurs3.Eğitmen = "Engin Demiroğ";
            kurs3.IzlenmeOranı = 88;

            Kurs kurs4 = new Kurs();
            kurs4.KursunAdı = "C++";
            kurs4.Eğitmen = "Haydar Tuna";
            kurs4.IzlenmeOranı = 57;
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };
            foreach(Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.Eğitmen);
                Console.WriteLine(kurs.KursunAdı);
                Console.WriteLine(kurs.IzlenmeOranı);
                Console.WriteLine("**********************");
            }
            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursunAdı { get; set; }
        public string Eğitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
