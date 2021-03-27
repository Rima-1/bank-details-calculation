using System;
using System.Collections.Generic;
using System.Text;

namespace BankDetailsCalculation
{
    class SBI : Bank
    {
        public static void CalculationSBI()
        {
            interestRate = (6.70 / 12) / 100;
            EMI(interestRate);
            InterestPayable();
            TotalPayableForHomeLoan();
        }
    }
}
