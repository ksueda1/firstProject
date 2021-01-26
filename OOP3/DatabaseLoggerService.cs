using System;
using System.Collections.Generic;

namespace OOP3
{
    class DatabaseLoggerService:ILoggerService

    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}


