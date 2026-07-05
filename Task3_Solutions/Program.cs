namespace Task3_Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Easy - Task 1 - Absolute Difference
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double difference = Math.Abs(num1 - num2);

            Console.WriteLine("The positive difference is: " + difference);


            //Easy - Task 2 - Power & Root Explorer
            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());

            double square = Math.Pow(number, 2);
            double squareRoot = Math.Sqrt(number);

            Console.WriteLine("Square: " + square);
            Console.WriteLine("Square Root: " + squareRoot);


            //Easy - Task 3 - Name formatter
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Uppercase: " + fullName.ToUpper());
            Console.WriteLine("Lowercase: " + fullName.ToLower());
            Console.WriteLine("Character count: " + fullName.Length);

            //Easy - Task 4 - Subscription End Date
            Console.Write("Enter number of trial days: ");
            int subDays = int.Parse(Console.ReadLine());

            DateTime endDate = DateTime.Today.AddDays(subDays);

            Console.WriteLine("Your trial ends on: " + endDate.ToString("yyyy-MM-dd"));



            //Medium - Task 5 - Grade Rounding System
            Console.Write("Enter your exam score: ");
            double rawScore = double.Parse(Console.ReadLine());

            double roundedScore = Math.Round(rawScore);

            Console.WriteLine("Rounded score: " + roundedScore);

            if (roundedScore >= 60)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }


            //Medium - Task 6 - Password Strength Checker
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            bool longEnough = (password.Length >= 8);
            bool containsForbiddenWord = password.ToLower().Contains("password");

            if (longEnough && !containsForbiddenWord)
            {
                Console.WriteLine("Strong");
            }
            else
            {
                Console.WriteLine("Weak");

                if (!longEnough)
                {
                    Console.WriteLine("Reason: Too short (needs 8+ characters).");
                }

                if (containsForbiddenWord)
                {
                    Console.WriteLine("Reason: Contains the word 'password'.");
                }
            }


            

        }
    }
}

