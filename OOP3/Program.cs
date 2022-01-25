using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            IhtiyacCreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            ihtiyacCreditManager.Calculate();

            TasitCreditManager tasitCreditManager = new TasitCreditManager();
            tasitCreditManager.Calculate();

            KonutCreditManager konutCreditManager = new KonutCreditManager();
            konutCreditManager.Calculate();
            */
            ///interface onu iplement eden class'ın referansını tutabilir.
            ///interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.

            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            ICreditManager tasitCreditManager = new TasitCreditManager();
            ICreditManager konutCreditManager = new KonutCreditManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafCreditManager(), loggers);
            

            List<ICreditManager> credits = new List<ICreditManager>() {ihtiyacCreditManager, tasitCreditManager };

           // basvuruManager.CreditInfo(credits);
            


            
        }
    }
}
