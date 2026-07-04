namespace Task2_Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Easy - Task 1 - Countdown timer 
            Console.WriteLine("Enter the number to start the countdown: ");
            int countdown = int.Parse(Console.ReadLine());

            for (int i = countdown; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");


            //Easy - Task 2 - Sum of numbers 1 to N
            Console.WriteLine("Enter a positvie whole number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of numbers from 1 to {number} is : {sum}");

            //Easy - Task 3 - Multiplication table
            Console.WriteLine("Enter a number to generate its multiplication table: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }

            
        }
    }
}

