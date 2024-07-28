using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Advance_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loan details
            double principal = 95000; // Loan amount in RM
            double annualInterestRate = 6.5; // Annual interest rate in percent
            double targetEMI = 1750; // Target monthly installment in RM

            // Calculate the loan period
            double loanPeriodYears = CalculateLoanPeriod(principal, annualInterestRate, targetEMI);

            // Display the result
            Console.WriteLine("To achieve a monthly installment of RM {0:0.00} or less, the loan period should be approximately {1:0.00} years.",
                targetEMI, loanPeriodYears);

            // Wait for user input before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        static double CalculateLoanPeriod(double principal, double annualInterestRate, double targetEMI)
        {
            double monthlyInterestRate = annualInterestRate / 100 / 12;

            // Calculate n using the rearranged EMI formula and logarithms
            double numerator = Math.Log(targetEMI) - Math.Log(targetEMI - (principal * monthlyInterestRate));
            double denominator = Math.Log(1 + monthlyInterestRate);
            double totalPayments = numerator / denominator;

            double loanPeriodYears = totalPayments / 12;

            return loanPeriodYears;
        }
    }
}
