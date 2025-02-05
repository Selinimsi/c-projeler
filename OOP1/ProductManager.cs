using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("ürün eklnd,");
        }
        public void Update(Product product)
        {
            Console.WriteLine("Güncellendi");
        }

        //void sadec işlm yapılması gerektiğinde kullanılır.
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
