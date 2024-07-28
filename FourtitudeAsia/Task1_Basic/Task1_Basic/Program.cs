using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loan details
            double principal = 95000; // Loan amount in RM
            double annualInterestRate = 6.5; // Annual interest rate in percent
            int years = 5; // Loan period in years

            // Calculate the EMI
            double monthlyRepayment = CalculateEMI(principal, annualInterestRate, years);

            // Display the result
            Console.WriteLine("The monthly repayment for a loan of RM {0} over {1} years at an annual interest rate of {2}% is RM {3:0.00}",
                principal, years, annualInterestRate, monthlyRepayment);

            // Wait for user input before closing
            Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }

        static double CalculateEMI(double principal, double annualInterestRate, int years)
        {
            double monthlyInterestRate = annualInterestRate / 100 / 12;
            int totalPayments = years * 12;

            double emi = principal * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, totalPayments) /
                         (Math.Pow(1 + monthlyInterestRate, totalPayments) - 1);

            return emi;
        }
    }
}
