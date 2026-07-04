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

            //Easy - Task 4 - Password Retry
            string pass = "Spark2026";

            Console.WriteLine("Enter the password: ");
            string userPass = Console.ReadLine();

            while (pass != userPass)
            {
                Console.WriteLine("Incorrect password. Please try again: ");
                userPass = Console.ReadLine();
            }
            Console.WriteLine("Access granted!");

            //Medium - Task 5 - Number Guessing Game
            int secretNumber = 42;
            int guess;
            int attempts = 0;

            do
            {
                Console.WriteLine("Guess the number");
                guess = int.Parse(Console.ReadLine());

                attempts = attempts + 1;

                if (guess > secretNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("Correct! You guessed the number in " + attempts + " attempts.");
                }
            }
            while (guess != secretNumber);
        }
    }
}

