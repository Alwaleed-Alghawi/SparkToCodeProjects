namespace Tas4_Solutions
{
    internal class Program
    {

        //Easy - Task 1 - Personalized Welcome Function
        public static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "! Great to have you here.");
        }



        static void Main(string[] args)
        {
            //Easy - Task 1 - Personalized Welcome Function Calling
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            PrintWelcome(userName);



        }
    }
}
