namespace Assignment1_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignments 1.1 (Part 1 of 4)
            Console.WriteLine("Hello, please enter your Name: ");
            string userName = Console.ReadLine()!;

            Console.WriteLine("\nPlease enter you age: ");
            double userAge = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPlease enter your address: ");
            string userAddress = Console.ReadLine()!;


            Console.WriteLine($"\n\nHello {userName}, you are {userAge} years old. You live at {userAddress}. Nice to meet you!");
            Console.WriteLine("\n\nPress any key to exit...");  
            Console.ReadKey(intercept: true);
            //Assignments 1.1 (Part 2 of 4)
        }
    }
}
