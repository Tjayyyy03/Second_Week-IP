using PaymentMethodBl;
using ObModels;
using System;

namespace Dejesus_OnlineBanking2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentMethodBL bl = new PaymentMethodBL();

            Console.WriteLine(" ================== PAYMENT SYSTEM ================== ");

            double productPrice = 370;
            double electricityBill = 1500;
            double waterBill = 800;

            string billType = "";
            double billAmount = 0;

            
            Console.WriteLine("\n======== BILL TYPE ========\n");
            Console.WriteLine("1. Product");
            Console.WriteLine("2. Electricity Bill");
            Console.WriteLine("3. Water Bill");
            Console.Write("Select Bill Type: ");
            string billChoice = Console.ReadLine();

            if (billChoice == "1")
            {
                billType = "Product";
                billAmount = productPrice;
            }
            else if (billChoice == "2")
            {
                billType = "Electricity Bill";
                billAmount = electricityBill;
            }
            else if (billChoice == "3")
            {
                billType = "Water Bill";
                billAmount = waterBill;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            Console.WriteLine($"Your bill is: {billAmount}");

            Console.WriteLine("\n======== PAYMENT METHOD ========\n");
            Console.WriteLine("\nSelect Payment Method:");
            Console.WriteLine("1. GCash");
            Console.WriteLine("2. PayMaya");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            string payMethod = choice == "1" ? "GCash" :
                               choice == "2" ? "PayMaya" : "Invalid";

            if (payMethod == "Invalid")
            {
                Console.WriteLine("Invalid payment method.");
                return;
            }

            
            Console.WriteLine("\n======== ACCOUNT INFORMATION =========");
            Console.Write("Enter Account Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Account Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

         
            Bills bill = bl.AddBill(payMethod, billType, name, number,amount);
            bill.BillAmount = billAmount;

            PrintReceipt(bill, amount);
        }

        static void PrintReceipt(Bills bill, double amount)
        {
            Console.WriteLine("\n========= PAYMENT RECEIPT =========");
            Console.WriteLine($"Payment Method: {bill.PaymentMethod}");
            Console.WriteLine($"Bill Type: {bill.BillType}");
            Console.WriteLine($"Account Name: {bill.AccountName}");
            Console.WriteLine($"Account Number: {bill.AccountNumber}");
            Console.WriteLine($"Bill Amount: P{bill.BillAmount}");
            Console.WriteLine($"Amount Paid: P{amount}");

            if (amount > bill.BillAmount)
            {
                Console.WriteLine($"Change: P{amount - bill.BillAmount}");
            }
            else if (amount == bill.BillAmount)
            {
                Console.WriteLine("Paid!");
            }
            else
            {
                Console.WriteLine("Not Paid");
            }
        }
    }
}