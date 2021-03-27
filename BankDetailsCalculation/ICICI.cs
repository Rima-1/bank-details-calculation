using System;
using System.Collections.Generic;
using System.Text;

namespace BankDetailsCalculation
{
    class ICICI : Bank
    {
        public static void CalculationICICI()
        {
            interestRate = (6.90 / 12) / 100;
            EMI(interestRate);
            InterestPayable();
            TotalPayableForHomeLoan();
        }
    }
}
