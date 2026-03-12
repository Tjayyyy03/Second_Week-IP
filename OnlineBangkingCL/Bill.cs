using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBangkingCL
{
    public class Bill
    {
        public string BillType { get; set; }
        public double BillAmount { get; set; }

        public void SelectBill(double productPrice, double electricityBill, double waterBill)
        {
            Console.WriteLine("\n======== BILL TYPE ========\n");
            Console.WriteLine("1. Product");
            Console.WriteLine("2. Electricity Bill");
            Console.WriteLine("3. Water Bill");
            Console.Write("Select Bill Type: ");
            string billChoice = Console.ReadLine();

            if (billChoice == "1") { BillType = "Product"; BillAmount = productPrice; }
            else if (billChoice == "2") { BillType = "Electricity Bill"; BillAmount = electricityBill; }
            else if (billChoice == "3") { BillType = "Water Bill"; BillAmount = waterBill; }
            else { BillType = "Invalid"; BillAmount = 0; }
        }
    }
}



