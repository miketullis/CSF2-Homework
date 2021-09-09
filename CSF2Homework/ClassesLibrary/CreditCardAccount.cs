using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2Homework
{
    public class CreditCardAccount

    {
            //fields 

            //properties
            public int AccountNumber { get; set; }
            public Customer CustomerInfo { get; set; }
            public decimal Balance { get; set; }
            public bool IsPastDue { get; set; }
            public decimal AnnualInterestRate { get; set; }

        //constructors
        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;

        }

        //methods
        public override string ToString()
        {
            return string.Format($"CREDIT CARD ACCOUNT\n" +
                                 $"===================\n" +
                                 $" Account Number: {AccountNumber}\n" +
                                 $"Account Balance: {Balance}\n" +
                                 $"       Past Due: {IsPastDue}\n" +
                                 $"  Intereset APR: {AnnualInterestRate}\n\n" +
                                 $"{CustomerInfo}");

        }//end ToString()


    }//end class
}//end namespace