using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"phyton","C#","java" };
            //for (int i = 0; i <3; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}
            foreach  (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.ReadLine();
        }
    }
}
