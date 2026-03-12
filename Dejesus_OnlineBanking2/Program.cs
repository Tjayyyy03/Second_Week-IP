using System;
using OnlineBangkingCL;

namespace Dejesus_OnlineBanking2
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine(" ================== Payment System ================== ");

            double ProductPrice = 370;
            double ElectricityBill = 1500;
            double WaterBill = 800;

            PaymentMethod method = new PaymentMethod();
            method.SelectMethod();

            Bill bill = new Bill();
            bill.SelectBill(ProductPrice, ElectricityBill, WaterBill);

            AccountInfo account = new AccountInfo();
            account.InputAccount();

            PaymentReceipt receipt = new PaymentReceipt
            {
                PaymentMethod = method,
                Bill = bill,
                AccountInfo = account
            };
            receipt.InputAmount();
            receipt.PrintReceipt();
        }
    }
}



