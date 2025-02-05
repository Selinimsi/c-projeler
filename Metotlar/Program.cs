using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Adi = "kalem etek";
            product.Açıklamasi = "tiriko kalem etek: hem rahat hem şık";
            product.Id = 1;
            product.Fiyat = 500;
            product.StokAdedi = 67;

            Product product1 = new Product();
            product1.Adi = "kargo pantolon";
            product1.Açıklamasi = "Kahverengi kargo pantolon";
            product1.Fiyat = 600;
            product1.Id = 2;
            product1.StokAdedi = 47;

            Product product2 = new Product();
            product2.Adi = "blazer ceket";
            product2.Açıklamasi = "siyah krop ceket";
            product2.Fiyat = 400;
            product2.Id = 3;
            product2.StokAdedi = 48;




            Product[] urunler = new Product[] {product,product1,product2 };
            foreach (Product urun in urunler)
            {
                Console.WriteLine( urun.Adi);
                Console.WriteLine("Açıklaması: "+urun.Açıklamasi);
                Console.WriteLine("Ürünün fiyatı: "+urun.Fiyat);
                Console.WriteLine("Kalan stok: " + urun.StokAdedi);
                Console.WriteLine("*************************");
            }
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);


            Console.ReadLine();
        }
    }
}
