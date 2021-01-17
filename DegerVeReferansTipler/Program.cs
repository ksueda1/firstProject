using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1); //30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]); //999

        }
    }
}

//stack ve heapg
//int, decimal, float, double, bool = değer tip
//array, class, interface = referans tip
//bellekte stack ve heap denilen iki tane alan var.
//bir değişken tanımlandığında değer tip olanlar stack'de gerçekleşiyor.
//başta sayi1 ve sayi2'yi eşitler, ikisi de 30 olur.
//sonra sayi2'yi 65'e eşitler. ama sayi1 ile ilgili geriye dönük işlem yapmaz.
//sayi1 30 olarak kalır.
//referanslar tipler:
//sayilar1 değişkenini stack'te tanımlar.
//new dediğimiz anda yeni oluşturduğumuz array'i heap'te tanımlar.
//stack'teki sayilar1 heap'te oluşan array'le ilişkilendirilir.
//sayilar1'in adresi heap'te gibi düşünülebilir.
//sayilar2 de stack'te tanımlanır, new array heap'te tanımlanır.
//ikisi birbiriyle ilişkilendirilir.
//(new: bellekten bir adres oluştur demek)
//sayilar1 = sayilar2 dediğimizde sayilar1'in ref. numarası sayilar2'nin ref numarasına eşittir şeklinde okunur.
//Yani stack'teki sayilar1'in adresi heap'teki sayilar2'nin tutulduğu adres oldu.
//ikisinin de adresi heap'teki sayilar2'nin array'i.
//sayilar2 array'inde bir eleman değişti, sayilar1 de aynı array'i tuttuğu için onun da elemanı değişmiş gibi oldu.
// bu C gibi dillerde karşımıza pointe olarak çıkar?????????
//sayilar1'in ilk başta tuttuğu array'i artık tutan bir değer yok.
//Bu yüzden .Net'in garbage collector'ı sayilar1'in ilk tanımlanan array'ini bellekten atar.
