using System;
using System.Collections.Generic;
using System.Text;

namespace BankDetailsCalculation
{
    class Citibank : Bank
    {
        public static void CalculationCitibank()
        {
            interestRate = (6.75 / 12) / 100;
            EMI(interestRate);
            InterestPayable();
            TotalPayableForHomeLoan();
        }
    }
}
