using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string>() {"Selin","Sezin","Ece","kısmet" };//dizilerden farklı olarak eleman ekleme konusunda sıkıntı çekmezsin
            
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ayşe");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);



            Console.ReadLine();
        }
    }
}
