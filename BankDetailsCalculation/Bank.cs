using System;
namespace BankDetailsCalculation
{
    public abstract class Bank
    {
        private static double emi;
        private static double payableInterest;
        private static double totalHomeLoanPayable;
        protected static long bankAccountNumber;
        protected static string accountHolderName;
        protected static long loanAmount;
        protected static int loanTenure;
        protected static double interestRate;
        public static long cibilScore;

        public static void TakeInputs()
        {
            Console.WriteLine("Enter Bank Account Number : ");
            bankAccountNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Holder Name : ");
            accountHolderName = Console.ReadLine();
            Console.WriteLine("Enter Loan Amount : ");
            loanAmount = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Loan Tenure in years : ");
            loanTenure = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CIBIL Score : ");
            cibilScore = long.Parse(Console.ReadLine());
        }
        protected  static void EMI(double gotinterestRate)
        {
            emi = (loanAmount * gotinterestRate * Math.Pow(1 + gotinterestRate, (loanTenure * 12))) / (Math.Pow(1 + gotinterestRate, (loanTenure * 12)) - 1);
            Console.WriteLine($"EMI Monthly : {emi:F0}");
        }
        protected  static void InterestPayable()
        {
            payableInterest = (emi * (loanTenure * 12)) - loanAmount;
            Console.WriteLine($"Interest Payable : {payableInterest:F0}");
        }
        protected  static void TotalPayableForHomeLoan()
        {
            totalHomeLoanPayable = loanAmount + payableInterest;
            Console.WriteLine($"Total Payable For Home Loan : {totalHomeLoanPayable:F0}");
        }
        
    }
}
