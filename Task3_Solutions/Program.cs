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



            //Medium - Task 7 - Clean Name Comparator
            Console.Write("Enter a name (first name): ");
            string name1 = Console.ReadLine();

            Console.Write("Enter a name (second name): ");
            string name2 = Console.ReadLine();

            string cleanName1 = name1.Trim().ToLower();
            string cleanName2 = name2.Trim().ToLower();

            if (cleanName1 == cleanName2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }


            //Medium - Task 8 - Membership Expiry Checker
            Console.Write("Enter membership start date (yyyy-MM-dd): ");
            string startDateText = Console.ReadLine();

            Console.Write("Enter number of valid membership days: ");
            int validDays = int.Parse(Console.ReadLine());

            try
            {
                DateTime startDate = DateTime.Parse(startDateText);
                DateTime expiryDate = startDate.AddDays(validDays);

                if (expiryDate >= DateTime.Today)
                {
                    Console.WriteLine("Active. Expires on: " + expiryDate.ToString("yyyy-MM-dd"));
                }
                else
                {
                    Console.WriteLine("Expired. Expired on: " + expiryDate.ToString("yyyy-MM-dd"));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid date format entered.");
            }


            //Hard - Task 9 - Round Up / Round Down Explorer
            Console.Write("Enter a decimal number: ");
            double value = double.Parse(Console.ReadLine());

            double nearest = Math.Round(value);
            double roundedUp = Math.Ceiling(value);
            double roundedDown = Math.Floor(value);

            Console.WriteLine("Nearest whole number: " + nearest);
            Console.WriteLine("Always rounded up: " + roundedUp);
            Console.WriteLine("Always rounded down: " + roundedDown);



            //Hard - Task 10 - Word Position Finder

            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.Write("Enter a word to search for: ");
            string word = Console.ReadLine();

            int firstPosition = sentence.IndexOf(word);
            int lastPosition = sentence.LastIndexOf(word);

            if (firstPosition == -1)
            {
                Console.WriteLine("Word not found.");
            }
            else
            {
                Console.WriteLine("First occurrence at position: " + firstPosition);
                Console.WriteLine("Last occurrence at position: " + lastPosition);
            }


            //Hard - Task 11 - OTP Generator
            Random random = new Random();
            int otp = random.Next(1000, 10000);

            Console.WriteLine("Your OTP code is: " + otp);

            int attempts = 0;
            bool verified = false;

            while (attempts < 3 && !verified)
            {
                try
                {
                    Console.Write("Enter the OTP to verify: ");
                    int userInput = int.Parse(Console.ReadLine());

                    attempts++;

                    if (userInput == otp)
                    {
                        verified = true;
                        Console.WriteLine("Verified");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect code. Try again.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input, please enter numbers only.");
                }
            }

            if (!verified)
            {
                Console.WriteLine("Verification Failed");
            }
        }
    }
}

