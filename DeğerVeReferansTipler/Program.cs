using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeğerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //değer tipler: int,dooble,boolen
            //referans tipler: array,class,interface
            int sayi1 = 30;
            int sayi2 = 60;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine("sayi 1 degeri= " + sayi1);//60 değerini yazdırır.


            int[] sayilar1 = new int[] {1,2,3 };

            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);//999 değeri yazdırır.




            Console.ReadLine();
        }
    }
}
