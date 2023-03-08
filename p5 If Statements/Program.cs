namespace p5_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double Balance, fee, StartingBal, Deposit, WithDraw ;
            int option;
            bool done = false;

            Random Generator = new Random();
            StartingBal = Generator.Next(100, 151);

            Console.WriteLine("Welcome to B.O.B");

            while (done != true)
            {
                Console.WriteLine("What Option would you like to do?");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1: DEPOSIT");
                Console.WriteLine("2: WITHDRAW");
                Console.WriteLine("3: QUIT");
                Console.WriteLine("---------------------------------");
                if (int.TryParse(Console.ReadLine(), out option)&& option >= 1 && option <= 3)
                {
                    if (option == 1)
                    {
                        Console.WriteLine("TEST 1");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                    }
                    else if (option == 2)
                    {
                        Console.WriteLine("TEST 2");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                    }
                    else if (option == 3)
                    {
                        Console.WriteLine("TEST 3");
                        Thread.Sleep(1000);
                        Console.WriteLine();
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