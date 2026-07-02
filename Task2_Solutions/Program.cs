namespace Task2_Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Easy - Task 1 - Countdown timer 
            Console.WriteLine("Enter the number to start the countdown:");
            int countdown = int.Parse(Console.ReadLine());

            for (int i = countdown; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");

        }
    }
}
