using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Başvuru bilgilerini değerlendirme (özellik)
            //özellik2
            //özellik3
            //vs...
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void CreditInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
