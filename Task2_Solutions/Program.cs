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


            //Medium - Task 6 - Safe Division Calculator
            try
            {
                Console.Write("Enter the first number to divide: ");
                int firstNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number to divide: ");
                int secondNumber = int.Parse(Console.ReadLine());
                int divisionResult = firstNumber / secondNumber;
                Console.WriteLine("The result of the division is: " + divisionResult);
            }
            catch (Exception e)
            {
                if (e is DivideByZeroException)
                {
                    Console.WriteLine("Numbers can't be divided by zero, please enter a number more than 0.");
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number");
                }
            }

            //Medium - Task 7 - Repeating Menu with Exit Option
            int choice = 0;

            Console.Write("Please enter your choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            while (choice != 3)
            {
                try
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello!");
                            break;

                        case 2:
                            Console.WriteLine("Greetings! today is 4 July 2024");
                            break;

                        case 3:
                            Console.WriteLine("Exit");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input, please enter a number");
                }

                if (choice == 3)
                {
                    break;
                }
                else
                {
                    Console.Write("Please enter your choice from the menu: ");
                    choice = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}

