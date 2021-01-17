using System;
namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        // sadece ekle fonksiyonu _Ekle()_ tek başına anlamsız. ne ekleyeceğini de söylememiz gerekir.
        // buna parametre denir
        // şu an metodumuz bir parametre (urun) alıyor.parametrenin tipi Urun.

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urun.Adi);
        }


        //aşağıdaki şekilde de yazılabilir ama tercih edilmez. yazmasan daha iyi işi uzatır.
        //özellikle ileride eklenmesi-çıkarılması gereken bir şey olursa tek tek düzeltmek gerekir.

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urunAdi);
        }
    }
}

//bir operasyon tutar. fonksiyon=metot