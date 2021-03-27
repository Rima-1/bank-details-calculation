using System;
using System.Collections.Generic;
using System.Text;

namespace BankDetailsCalculation
{
   public class BOB : Bank
    {
        
        public static void CalculationBOB()
        {
            interestRate = (6.85/12)/100;
            EMI(interestRate);
            InterestPayable();
            TotalPayableForHomeLoan();
        }
    }
}
