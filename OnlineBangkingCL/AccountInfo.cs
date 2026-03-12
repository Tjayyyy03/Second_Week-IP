using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBangkingCL
{
    public class AccountInfo
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }

        public void InputAccount()
        {
            Console.WriteLine("\n========= Account Info =========");
            Console.Write("Enter Account Name: ");
            AccountName = Console.ReadLine();

            Console.Write("Enter Account Number: ");
            AccountNumber = Console.ReadLine();
        }
    }
}

