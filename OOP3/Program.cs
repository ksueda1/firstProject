using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            
            IKrediManager tasitKrediManager = new TasitKrediManager();
            
            IKrediManager konutKrediManager = new KonutKrediManager();

            //yukarıdakileri ekrandaki başvuru kutusu gibi düşün.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            //şimdi başvuru ekranını kullanarak başvuruyu yapıyoruz.

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);
            //yukarıdaki verdiğimiz tek bir kredi türünü hesaplar.


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager };
            List<ILoggerService> loggerServices = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() };
            //liste oluşturma yukarıdaki iki şekilde de olabilir.

            basvuruManager.KrediOnBilgilendirmesiYap(krediler, loggerServices);
            //yukarıdaki verilen farklı kredi türlerini hesaplar.


        }
    }
}
