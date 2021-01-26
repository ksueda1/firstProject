using System;
using System.Collections.Generic;

namespace OOP3
{
    class BasvuruManager
    {

        //method injenction
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            krediManager.Hesapla();
            //hangi kredi türünü gönderirsek onu hesaplar.
            loggerService.Log();

        }

        //belirsiz sayıda kredi hesaplamak için:

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler, List<ILoggerService> loggerServices)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

            foreach (var logger in loggerServices)
            {
                logger.Log();
            }


        }

        
}
