using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBangkingCL
{
    public class PaymentReceipt
    {
        public PaymentMethod PaymentMethod { get; set; }
        public Bill Bill { get; set; }
        public AccountInfo AccountInfo { get; set; }
        public double Amount { get; set; }

        public void InputAmount()
        {
            Console.Write("Enter Amount: ");
            Amount = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintReceipt()
        {
            Console.WriteLine("\n========= Payment Receipt =========");
            Console.WriteLine($"Payment Method: {PaymentMethod.PayMethod}");
            Console.WriteLine($"Bill Type: {Bill.BillType}");
            Console.WriteLine($"Account Name: {AccountInfo.AccountName}");
            Console.WriteLine($"Account Number: {AccountInfo.AccountNumber}");
            Console.WriteLine($"Amount: P{Amount}");

            if (Amount > Bill.BillAmount)
                Console.WriteLine($"Change: P{Amount - Bill.BillAmount}");
            else if (Amount == Bill.BillAmount)
                Console.WriteLine("Paid!");
            else
                Console.WriteLine("Not Paid");
        }
    }
}


