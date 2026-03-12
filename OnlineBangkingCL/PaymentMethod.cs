using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBangkingCL
{
    public class PaymentMethod
    {
        public string PayMethod { get; set; }

        public void SelectMethod()
        {
            Console.WriteLine("Select Payment Method: ");
            Console.WriteLine("1. GCash");
            Console.WriteLine("2. PayMaya");
            Console.Write("Enter choice (1 or 2): ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1": PayMethod = "GCash"; break;
                case "2": PayMethod = "PayMaya"; break;
                default: PayMethod = "Invalid"; break;
            }
        }
    }
}
