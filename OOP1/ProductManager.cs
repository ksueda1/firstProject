using System;
namespace OOP1
{
    class ProductManager
    {
        
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }

        /*
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2 
        }

        ----üstteki örnekte formül sonucu başka bir yerde de kullanılabilir.

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        ----void git yap bitir

        */
    }
}
