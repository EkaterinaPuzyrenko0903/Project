using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CashPaySolver
    {
        public double SumScore { get; set; }//Сумма счета
        public double SumPayment { get; set; }//Сумма платежа
        public double Sum { get; set; }//Сумма платежа к счету
        public double dolya { get; set; }
        public DateTime date { get; set; }

    }
}
