using System.Reflection.Metadata;
using System.Transactions;

namespace p5_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double Balance, fee, StartingBal, Deposit, WithDraw, Bill, Interest;
            int option;
            string choice;
            bool done = false;
            fee = 0.75;
            Random Generator1 = new Random();
            Bill = Generator1.Next(100, 151);
            Random Generator = new Random();
            StartingBal = Generator.Next(100, 151);
            Balance = StartingBal;
            Interest = Bill / 10;
            Math.Round(Bill, 2);
            Console.WriteLine("Welcome to B.O.B");

            while (done != true)
            {
                Console.WriteLine($"Your Balance is:{Balance}$");
                Console.WriteLine("What Option would you like to do?");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1: DEPOSIT");
                Console.WriteLine("2: WITHDRAWAL");
                Console.WriteLine("3: BILL PAYMENT");
                Console.WriteLine("4: BALANCE UPDATE");
                Console.WriteLine("5: QUIT");
                Console.WriteLine("---------------------------------");
                if (int.TryParse(Console.ReadLine(), out option) && option >= 1 && option <= 5)
                {
                    if (option == 1)
                    {
                        Console.WriteLine($"You currently have {Balance}$.");
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
                                Console.WriteLine($"Account Update: {Balance}$");
                            }
                        }
                        else
                            Console.WriteLine("Invalid Input");
                    }
                    else if (option == 2)
                    {
                        Console.WriteLine($"You currently have {Balance} $.");
                        Console.WriteLine("How much would you like to withdraw?(0.75$ fee)");

                        if (Double.TryParse(Console.ReadLine(), out WithDraw))
                        {
                            if (WithDraw > Balance - fee)
                            {
                                Console.WriteLine("Invaild Input");
                            }

                            else if (WithDraw == Balance - fee && 0 > Balance)
                            {
                                Console.WriteLine("Invaild Input");
                            }
                            else
                            {

                                Balance = Balance - WithDraw - fee;
                                WithDraw = Math.Round(WithDraw, 2);
                                Console.WriteLine($"Your new Balance is {Balance}$.");
                            }
                        }
                        else
                            Console.WriteLine("Invalid Input");
                    }
                    else if (option == 3)
                    {
                        Console.WriteLine($"Bills Payable: 1. Amount owed: {Bill}$");
                        Console.WriteLine("Would you like to pay this bill? Yes, No?");
                        choice = Console.ReadLine().ToLower();
                        if (choice == "yes" || choice == "yes " || choice == " yes" || choice == "yes." || choice == "y")
                        {
                            if (Bill > Balance)
                                Console.WriteLine("Invalid Funds.");
                            else
                            {
                                Console.WriteLine("Transaction Complete!");
                                Balance = Balance - Bill;
                                Console.WriteLine($"Your new Balance is {Balance}$.");
                            }

                        }
                        else if (choice == "no" || choice == "no " || choice == " no" || choice == "no." || choice == "n")
                        {
                            Console.WriteLine("10% interest added to bill...");
                            Bill = Bill + Interest;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input! Try Again.");
                        }
                    }
                    else if (option == 4)
                    {
                        Console.WriteLine($"Your new balance is {Balance}$");
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
                    Console.WriteLine("INVALID INPUT!!! Try putting in \"1\", \"2\", \"3\", \"4\", \"5\".");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                }
            }
        }
    }
}