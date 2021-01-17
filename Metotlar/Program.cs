using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            // string urunAdi = "Elma"; normalde tanımlamayaı böyle yaparız ama class
            // olduğu zaman Class urun1 = new Class() ; şeklinde tanımlanır.
            //string array--> string[] meyveler = new string[] {"elma","karpuz"};

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            //type-safe/tip güvenli (python'da veri tipini yazmayız mesela)
            //foreach (Urun urun in urunler)
            //foreach (var urun in urunler) yazsaydık da olurdu.

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");

            }

            Console.WriteLine("-------------Metotlar--------------");

            //instance-class örneği oluşturuyoruz
            //encapsulation (class oluşturarak muhtemel bir değişikliği tek bi yerde yapmanı sağlar.)

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);




        }
    }
}


//do not repeat yourself - DRY - Clean Code - Best Practice
