using System.Reflection.Metadata;
using System.Transactions;

namespace p5_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double Balance, fee, StartingBal, Deposit, WithDraw, Bill, minutes, Charge;
            int option;
            string choice;
            bool done1 = false;
            bool done2 = false;
            bool done3 = false;
            fee = 0.75;
            Random Generator1 = new Random();
            Bill = Generator1.Next(100, 151);
            Random Generator = new Random();
            StartingBal = Generator.Next(100, 151);
            Balance = StartingBal;
            Console.WriteLine("Welcome to B.O.B");
            Charge = 0;
            while (done1 != true)
            {
                // Bank of Blorb program
                Console.WriteLine($"Your Balance is:{Balance}$");
                Console.WriteLine("What Option would you like to do?");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1: DEPOSIT");
                Console.WriteLine("2: WITHDRAWAL");
                Console.WriteLine("3: BILL PAYMENT");
                Console.WriteLine("4: BALANCE UPDATE");
                Console.WriteLine("5: QUIT");
                Console.WriteLine("---------------------------------");
                if (int.TryParse(Console.ReadLine(), out option) && option >= 1 && option <= 5) // Makes sure theres no invalid input
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
                            Console.WriteLine("");
                            Math.Round(Bill, 2);
                            Console.WriteLine($"Your Bill is {Bill}$.");
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
                        done1 = true;
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
            Console.WriteLine();
            Console.WriteLine("Welcome to Sam's Parking Lot!");//Parking lot program
            Console.WriteLine("How many minutes have you been parked? Max Minute Limit is 540(9 Hours)");
            while (!done2)
            {
                if (Double.TryParse(Console.ReadLine(), out minutes))
                {
                    if (minutes < 0)
                        Console.WriteLine("Invalid Input");
                    else if (minutes > 540) // More than 9 hours
                    {
                        Console.WriteLine("Illegal Input!");
                        Thread.Sleep(1000);
                        Console.WriteLine("Illegal Input!");
                        Thread.Sleep(1000);
                        Console.WriteLine("Illegal Input!");
                        Thread.Sleep(800);
                        Charge = Charge + 10000;
                        Console.WriteLine($"Your bill is {Charge}$");
                        Thread.Sleep(700);
                        Console.WriteLine("You Are Under Arrest!!!");
                        Thread.Sleep(500);
                        done2 = true;
                    }
                    else //Valid Input - Calculate Charges
                    {
                        Console.WriteLine("Calculating...");
                        Thread.Sleep(850);
                        if (minutes <= 60)
                        {
                            Charge = Charge + 4;
                            Console.WriteLine("You are being charged for the hour.");
                            Console.WriteLine($"Your bill is {Charge}$");
                            done2 = true;
                        }
                        else if (minutes <= 120 && minutes > 60)
                        {
                            Charge = Charge + 6;
                            Console.WriteLine("You are being charged for 2 hours.");
                            Console.WriteLine($"Your bill is {Charge}$");
                            done2 = true;
                        }
                        else if (minutes <= 180 && minutes > 120)
                        {
                            Charge = Charge + 8;
                            Console.WriteLine("You are being charged for 3 hours.");
                            Console.WriteLine($"Your bill is {Charge}$");
                            done2 = true;
                        }
                        else if (minutes <= 240 && minutes > 180)
                        {
                            Charge = Charge + 10;
                            Console.WriteLine("You are being charged for 4 hours.");
                            Console.WriteLine($"Your bill is {Charge}$");
                            done2 = true;
                        }
                        else if (minutes <= 300 && minutes > 240)
                        {
                            Charge = Charge + 12;
                            Console.WriteLine("You are being charged for 5 hours.");
                            Console.WriteLine($"Your bill is {Charge}$");
                            done2 = true;
                        }
                        else if (minutes <= 360 && minutes > 300)
                        {
                            Charge = Charge + 14;
                            Console.WriteLine("You are being charged for 6 hours.");
                            Console.WriteLine($"Your bill is {Charge}$");
                            done2 = true;
                        }
                        else if (minutes <= 420 && minutes > 360)
                        {
                            Charge = Charge + 16;
                            Console.WriteLine("You are being charged for 7 hours.");
                            Console.WriteLine($"Your bill is {Charge}$");
                            done2 = true;
                        }
                        else if (minutes <= 480 && minutes > 420)
                        {
                            Charge = Charge + 18;
                            Console.WriteLine("You are being charged for 8 hours.");
                            Console.WriteLine($"Your bill is {Charge}$");
                            done2 = true;
                        }
                        else if (minutes <= 540 && minutes > 480)
                        {
                            Charge = Charge + 20;
                            Console.WriteLine("You are being charged for 9 hours.");
                            Console.WriteLine($"Your bill is {Charge}$");
                            done2 = true;
                        }

                    }

                }
                else
                    Console.WriteLine("Invalid Input!!!");
            }
            while (!done3)//Hurricane Program
            {
                Console.WriteLine("What hurricane catagory from 1 to 5 do you want to know about?");
                if (int.TryParse(Console.ReadLine(), out option) && option >= 1 && option <= 5)
                {
                    switch (option)
                    {
                        case 1: Console.WriteLine("Catagory 1:74-95mph or 64-82kt or 119-153km/hr");
                            done3 = true;
                            break;
                        case 2: Console.WriteLine("Catagory 2:96-110mph or 83-95kt or 154-177km/hr");
                            done3 = true;
                            break;
                        case 3: Console.WriteLine("Catagory 3:111-130mph or 96-113kt or 178-209km/hr");
                            done3 = true;
                            break;
                        case 4: Console.WriteLine("Catagory 4:131-155mph or 114-135kt or 210-249km/hr");
                            done3 = true;
                            break;
                        case 5: Console.WriteLine("Catagory 5:Greater than 155mph or 135kt or 249km/hr");
                            done3 = true;
                            break;
                        default:
                            Console.WriteLine("INVALID INPUT!");
                            break;
                    }
                }
            }
        }
    }
}