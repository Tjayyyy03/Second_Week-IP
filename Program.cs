namespace Dejesus_OnlineBanking
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(" ================== Payment System ================== ");

            string paymentMethod;
            Boolean another = false;
            char AnoTrans;
            for (int i = 0; i < 3; i++)
            {
                {
                    Console.WriteLine("Select Payment Method: ");
                    Console.WriteLine("1. GCash");
                    Console.WriteLine("2. PayMaya");
                    Console.Write("Enter choice (1 or 2): ");
                    var choice = Console.ReadLine();

                    switch (choice)
                    {

                        case "1":
                            paymentMethod = "GCash";

                            Console.Write("Enter GCash Number: ");
                            var gcashNumber = Console.ReadLine();
                            Console.Write("Enter Amount: ");
                            var GCashInput = Console.ReadLine();


                            Console.WriteLine("\n========= Payment Receipt =========");
                            Console.WriteLine("Shopee Confirmation");
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("Payment Method: " + paymentMethod);
                            Console.WriteLine("GCash Number: " + gcashNumber);
                            Console.WriteLine("Amount: " + "P" + GCashInput);
                            Console.WriteLine("Status: Paid!");
                            Console.WriteLine("------------------------------------");
                            break;

                        case "2":
                            paymentMethod = "PayMaya";


                            Console.Write("Enter PayMaya Number: ");
                            var PayMayaNumber = Console.ReadLine();
                            Console.Write("Enter Amount: ");
                            var PayMayaAmount = Console.ReadLine();

                            Console.WriteLine("\n========= Payment Receipt =========");
                            Console.WriteLine("Shopee Confirmation");
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("Payment Method: " + paymentMethod);
                            Console.WriteLine("GCash Number: " + PayMayaNumber);
                            Console.WriteLine("Amount: " + "P" + PayMayaAmount);
                            Console.WriteLine("Status: Paid!");
                            Console.WriteLine("------------------------------------");

                            break;
                        default:
                            Console.WriteLine("Invalid Attempt. ");
                            break;
                    }
                }

                if (!another)
                {
                    Console.Write("\nDo you want to Continue? (y/n): ");
                    var ConChoi = Console.ReadLine();

                    if (ConChoi == "y" || ConChoi == "Y")
                    {
                        another = true;
                    }
                    else if (ConChoi == "n" || ConChoi == "N")
                    {
                        Console.WriteLine("Thank you for using our Payment System!");
                        break;
                    }

                    Console.WriteLine("\nDo You Want Another Transaction? (y/n): ");
                    AnoTrans = Convert.ToChar(Console.ReadLine);


                }
            }
        }
    }
}
