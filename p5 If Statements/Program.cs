namespace p5_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double Balance, fee, StartingBal, DepoAmt, WitDra ;
            int option1, option2, option3, option;
            Random Generator = new Random();
            StartingBal = Generator.Next(100, 151);

            Console.WriteLine("Hello User!, Welcome to B.O.B");
            Console.WriteLine("What Option would you like to do?");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1: DEPOSIT");
            Console.WriteLine("2: WITHDRAW");
            Console.WriteLine("3: QUIT");
            Console.WriteLine("---------------------------------");
            int program;
            if (Int32.TryParse(Console.ReadLine(), out option))
            {
                if (option == 1)
                {
                    option1();
                }
                else if (option == 2)
                {
                    option2();
                }
                else if (option == 3)
                {
                    option3();
                }
                else
                {
                    Console.WriteLine("That isn't an option!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }



        }
    }
}