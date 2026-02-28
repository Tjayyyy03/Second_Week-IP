using System;

namespace Dejesus_OnlineBanking2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(" ================== Payment System ================== ");

            double ProductPrice = 370;
            double ElectricityBill = 1500;
            double WaterBill = 800;
            bool another = false; 
            double amount;

                string PaymentMethod = "";
                string BillType = "";
                double BillMin = 0;

                    Console.WriteLine("Select Payment Method: ");
                    Console.WriteLine("1. GCash");
                    Console.WriteLine("2. PayMaya");
                    Console.Write("Enter choice (1 or 2): ");
                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            PaymentMethod = "GCash";
                            break;

                        case "2":
                            PaymentMethod = "PayMaya";
                            break;

                        default:
                            Console.WriteLine("Invalid Payment Method");
                            break;
                    }

                  
                        Console.WriteLine("\n======== BILL TYPE ========\n");
                        Console.WriteLine("1. Product");
                        Console.WriteLine("2. Electricity Bill");
                        Console.WriteLine("3. Water Bill");
                        Console.Write("Select Bill Type: ");
                        string Billtype = Console.ReadLine();

                    Console.WriteLine("\n========= Account Info =========");
                    Console.Write("\nEnter Account Name: ");
                    string AccountName = Console.ReadLine();

                    Console.Write("Enter Account Number: ");
                    string AccountNumber = Console.ReadLine();


                  
                        Console.Write("Enter Amount: ");
                        amount = Convert.ToDouble(Console.ReadLine());

                        if (amount <= 0)
                        {
                            Console.WriteLine("Invalid Amount. Please Try Again. ");
                        }

                        if (amount < BillMin)
                        {
                            Console.WriteLine("Not Paid");
                        }
                        else if (amount == BillMin)
                        {
                            Console.WriteLine("Paid");
                        }
                        else
                        {
                            Console.WriteLine("Exceed the payment");
                        }

                            if (Billtype == "1")
                            {
                                BillType = "Product";
                                BillMin = ProductPrice;
                                Console.WriteLine("Your Bill is: " + "P" + ProductPrice);
                                Console.WriteLine("\n========= Payment Receipt =========");
                                Console.WriteLine("Payment Method: " + PaymentMethod);
                                Console.WriteLine("Bill Type: " + BillType);
                                Console.WriteLine("Account Name: " + AccountName);
                                Console.WriteLine("Account Number: " + AccountNumber);
                                Console.WriteLine("Amount: " + "P" + amount);

                    
                              if (amount > BillMin)
                    {
                        Console.WriteLine("Change: " + "P" + (amount - BillMin));
                    } else if (amount == BillMin)
                    {
                        Console.WriteLine("Paid!");
                    } else if (amount < BillMin)
                    {
                        Console.WriteLine("Not Paid");
                    }
                }
                            else if (Billtype == "2")
                            {
                                BillType = "Electricity Bill";
                                BillMin = ElectricityBill;
                                Console.WriteLine("Your Bill is: " + "P" + ElectricityBill);
                                Console.WriteLine("\n========= Payment Receipt =========");
                                Console.WriteLine("Payment Method: " + PaymentMethod);
                                Console.WriteLine("Bill Type: " + BillType);
                                Console.WriteLine("Account Name: " + AccountName);
                                Console.WriteLine("Account Number: " + AccountNumber);
                                Console.WriteLine("Amount: " + "P" + amount);

                           if (amount > BillMin)
                    {
                        Console.WriteLine("Change: " + "P" + (amount - BillMin));
                    } else if (amount == BillMin)
                    {
                        Console.WriteLine("Paid!");
                    } else if (amount < BillMin)
                    {
                        Console.WriteLine("Not Paid");
                    }
                }
                            
                            else if (Billtype == "3")
                            {
                                BillType = "Water Bill";
                                BillMin = WaterBill;
                                Console.WriteLine("Your Bill is: " + "P" + WaterBill);
                                Console.WriteLine("\n========= Payment Receipt =========");
                                Console.WriteLine("Payment Method: " + PaymentMethod);
                                Console.WriteLine("Bill Type: " + BillType);
                                Console.WriteLine("Account Name: " + AccountName);
                                Console.WriteLine("Account Number: " + AccountNumber);
                                Console.WriteLine("Amount: " + "P" + amount);

                    if (amount > BillMin)
                    {
                        Console.WriteLine("Change: " + "P" + (amount - BillMin));
                    }
                    else if (amount == BillMin)
                    {
                        Console.WriteLine("Paid!");
                    }
                    else if (amount < BillMin)
                    {
                        Console.WriteLine("Not Paid");
                    }
                }
            
                            else
                            {
                                Console.WriteLine("Invalid Bill Type. Please Try again. ");
                            }
                        }
                        }
                    }
                
            
       
   

