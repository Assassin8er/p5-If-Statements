using System.Reflection.Metadata;
using System.Transactions;

namespace p5_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double Balance, fee, StartingBal, Deposit, WithDraw;
            int option;
            bool done = false;
            fee = 0.75;
            Random Generator = new Random();
            StartingBal = Generator.Next(100, 151);
            Balance = StartingBal;
            Console.WriteLine("Welcome to B.O.B");

            while (done != true)
            {
                Console.WriteLine("What Option would you like to do?");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1: DEPOSIT");
                Console.WriteLine("2: WITHDRAWAL");
                Console.WriteLine("3: BILL PAYMENT");
                Console.WriteLine("4: BALANCE UPDATE");
                Console.WriteLine("5: QUIT");
                Console.WriteLine("---------------------------------");
                if (int.TryParse(Console.ReadLine(), out option)&& option >= 1 && option <= 5)
                {
                    if (option == 1)
                    {
                        Console.WriteLine("You currently have " + Balance + "$");
                        Console.WriteLine("What would you like to deposit?(0.75$ fee)");
                        if (Double.TryParse(Console.ReadLine(), out Deposit))
                        {
                            if (Deposit < 5)
                                Console.WriteLine("Transaction Failed");
                            else
                            {
                                Balance = Balance + Deposit - fee;
                                Balance = Math.Round(Balance, 2);
                                Console.WriteLine();
                                Console.WriteLine("Account Update: " + Balance + "$");
                            }
                        }
                        else
                            Console.WriteLine("Invalid Input");
                    }
                    else if (option == 2)
                    {
                        Console.WriteLine("You currently have " + Balance + "$");
                        Console.WriteLine("How much would you like to withdraw?(0.75$ fee)");

                        if (Double.TryParse(Console.ReadLine(), out WithDraw))
                        {
                            if (WithDraw > Balance - fee)
                            {
                                Console.WriteLine("Invaild Input");
                            }
                        }
                        else if (WithDraw == Balance - fee)
                        {
                            Console.WriteLine("Invaild Input");
                        }
                        else
                        {
                           
                            Balance = Balance - WithDraw - fee;
                            Console.WriteLine($"Your new Balance is {Balance}");
                            WithDraw = Math.Round(WithDraw, 2);
                        }


                    }
                    else if (option == 3)
                    {

                    }
                    else if (option == 4)
                    {
                        
                    }
                    else if (option == 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Have a good day!");
                        Thread.Sleep(3000);
                        done = true;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("INVALID INPUT!!! Try putting in \"1\", \"2\", \"3\".");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                }
            }
        }
    }
}