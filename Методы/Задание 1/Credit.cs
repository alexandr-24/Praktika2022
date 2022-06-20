using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public class Credit
    {
        private double SummaCredita; // Сумма кредита
        
        public Credit (double summa)
        {
            SummaCredita = summa;
        }

        public string GetPayment(double payment)
        {
            if (payment >= SummaCredita)
            {
                SummaCredita -= payment;
                return "Кредит погашен. Переплата составила " + Math.Abs (SummaCredita) + " рублей.";
            }
            else
            {
                SummaCredita -= payment;
                return "Задолжность составляет " + SummaCredita + " рублей.";
            }
            
        }

    }
}
