using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "engin", "murat", "kerem", "halil" };
            //console.writeline(isimler[0]);
            //console.writeline(isimler[1]);
            //console.writeline(isimler[2]);
            //console.writeline(isimler[3]);

            //alttaki kod çalışmaz. çünkü array'in sınırı bu şekilde genişletilemez.
            //isimler[4] = "İlker"
            //Console.WriteLine(isimler[4]);

            //aşağıdaki şekilde çalışır.ama biz burada bomboş bir array oluşturmuş olduk.
            //yani stack'in eşleştiği yeni adreste sadece 4.elemanı tanımlı olan yeni bir array var artık.
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);

            //sonradan eleman ekleme zorluğu olduğu için dizilerle çalışılmıyor.koleksiyonlar kullanılıyor.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            
            
        }
    }
}

Dictionary
