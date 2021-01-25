using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() {fileLoggerService,databaseLoggerService };
            

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,new List<ILoggerService> { new DatabaseLoggerService() });
            basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> { fileLoggerService });
            basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> { databaseLoggerService });
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),
                new List<ILoggerService> { new DatabaseLoggerService(),new SmsLoggerService() });
            basvuruManager.BasvuruYap(ihtiyacKrediManager, loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            Console.ReadLine();
        }
    }
}
