using System;

namespace BankDetailsCalculation
{
    public class Program
    {
       public static void Main(string[] args)
        {
            string bankName;
            Console.WriteLine("Enter Bank Name : ");
            bankName = Console.ReadLine();
            Bank.TakeInputs();

            if (Bank.cibilScore > 700)
            {
                if (bankName.Equals("BOB", StringComparison.OrdinalIgnoreCase))
                {
                    BOB.CalculationBOB();    
                }
                else if (bankName.Equals("SBI", StringComparison.OrdinalIgnoreCase))
                {
                    SBI.CalculationSBI();
                }
                else if (bankName.Equals("ICICI", StringComparison.OrdinalIgnoreCase))
                {
                    ICICI.CalculationICICI();
                }
                else if (bankName.Equals("Citibank", StringComparison.OrdinalIgnoreCase))
                {
                    Citibank.CalculationCitibank();
                }
                else
                    Console.WriteLine("Account Holder Not Eligible for loan");
            }
            else
                Console.WriteLine("Account Holder Not Eligible for loan");
            
        }
    }
}
