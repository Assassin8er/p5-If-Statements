namespace p5_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int person1, person2, person3;
            Console.WriteLine("This program will determine age differences");
            Console.WriteLine("Please enter the age of the FIRST person below:");
            person1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the age of the SECOND person below:");
            person2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the age of the THIRD person below:");
            person3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (person1 > person2)
                Console.WriteLine("Person 1 is older than person 2");
            else if (person1 > person3)
                Console.WriteLine("Person 3 is younger than person 1");
            else if (person2 == person3)
                Console.WriteLine("Person 2 and person 3 are the same age");
                
            

            if (person1 > person2 && person3 > person2)
                Console.WriteLine("Person 2 is the youngest.");
            else if (person1 > person3 && person2 > person3)
                Console.WriteLine("Person 3 is the youngest.");
            else if (person2 > person1 && person3 > person1)
                Console.WriteLine("Person 1 is the youngest.");



            if (person3 > person2 && person3 > person1)
                Console.WriteLine("Person 3 is the oldest.");
            else if (person1 > person2 && person1 > person3)
                Console.WriteLine("Person 1 is the oldest.");
            else if (person2 > person3 && person2 > person1)
                Console.WriteLine("Person 2 is the oldest.");

            if (person2 == person3 && person2 != person1 || person2 == person1 && person2 != person3)
                Console.WriteLine("Person 2 is the same age as 1 other person");

            if (person1 == person2 && person3 != person1 || person1 == person3 && person1 != person2)
                Console.WriteLine("Person 1 is the same age as 1 other person");

            if (person1 == person2 && person2 == person3)
                Console.WriteLine("Everyone is the same age");
            else if (person1 == person2 && person1 != person3 || person2 == person3 && person3 != person1 || person1 == person3 && person1 != person2)
                Console.WriteLine("Exactly 2 people are the same age, but not everyone");
            else if (person1 != person2 && person1 != person3 && person2 != person1 && person2 != person3)
                Console.WriteLine("everyone is a different age");
        }
    }
}