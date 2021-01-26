using System;
using System.Collections.Generic;

namespace OOP3
{
    class FileLoggerService : ILoggerService

    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}


