using System.Runtime.CompilerServices;

namespace C__Fundamentals_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Easy - Task 1 - Personal Info Card
            string name = "Alwaleed";
            int age = 22;
            double height = 1.85;
            bool student = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            if (student)
            {
                Console.WriteLine("You are a student.");
            }
            else
            {
                Console.WriteLine("You are not a student.");
            }


            //Easy - Task 2 - Rectangle Calculator
            Console.WriteLine("Enter lenght: ");
            float length = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            float width = float.Parse(Console.ReadLine());

            float area = length * width;
            float perimeter = 2 * (length + width);

            Console.WriteLine("Area of the Rectangle: " + area);
            Console.WriteLine("Perimeter of the Rectangle: " + perimeter);


            //Easy - Task 3 - Even or Odd Checker
            Console.WriteLine("Enter a whole number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number " + number + " is even");
            }
            else if (number % 2 != 2)
            {
                Console.WriteLine("The number " + number + " is odd");
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }


            //Easy - Task 4 - Voting Eligibility
            Console.WriteLine("Enter your Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you have a valid ID? (yes/no): ");
            string id = Console.ReadLine();

            bool validId = (id == "yes");

            if (age >= 18 && validId)
            {
                Console.WriteLine("You are Eligible To Vote!");
            }
            else
            {
                Console.WriteLine("Sorry, You are not Eligible To Vote.");
            }

            //Easy - Task 5 - Grade Letter Lookup
            Console.WriteLine("Enter your grade (Letters only): ");
            char grade = char.Parse(Console.ReadLine());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("A > Excellent");
                    break;

                case 'B':
                    Console.WriteLine("B > Very Good");
                    break;

                case 'C':
                    Console.WriteLine("C > Good");
                    break;

                case 'D':
                    Console.WriteLine("D > Pass");
                    break;

                case 'F':
                    Console.WriteLine("F > Fail");
                    break;
            }

            //Medium - Task 6 - Temperature Converter
            Console.WriteLine("Enter a temperature in Celsius: ");
            float Ctemp = float.Parse(Console.ReadLine());

            float Fahrenheit = (Ctemp * 8 / 5) + 32;

            if (Ctemp < 10)
            {
                Console.WriteLine("Weather temperature in Fahrenheit: " + Fahrenheit);
                Console.WriteLine("Weather Condition: Cold");
            }
            else if (Ctemp >= 10 && Ctemp <= 30)
            {
                Console.WriteLine("Weather temperature in Fahrenheit: " + Fahrenheit);
                Console.WriteLine("Weather Condition: Mild");
            }
            else
            {
                Console.WriteLine("Weather temperature in Fahrenheit: " + Fahrenheit);
                Console.WriteLine("Weather Condition: Hot");
            }

            //Medium - Task 7 - Movie Ticket Pricing
            Console.WriteLine("Enter your Age: ");
            int age2 = int.Parse(Console.ReadLine());

            double ticketPrice = 0.0;

            if (age2 <= 12)
            {
                ticketPrice = 2.000;
                Console.WriteLine("You are a Child, The price of the ticket is " + ticketPrice + " OMR.");
            }
            else if (age2 <= 59)
            {
                ticketPrice = 5.000;
                Console.WriteLine("You are an Adult, The price of the ticket is " + ticketPrice + " OMR.");
            }
            else
            {
                ticketPrice = 3.000;
                Console.WriteLine("You are a Senior, The price of the ticket is " + ticketPrice + " OMR.");
            }

            //Medium - Task 8 - Resturant Bill with membership discount
            Console.WriteLine("Enter the total bill amount: ");
            double bill = double.Parse(Console.ReadLine());

            Console.WriteLine("Are you a member in out resturant (yes/no): ");
            string loyalty = Console.ReadLine();

            bool member = (loyalty == "yes");

            double discount = 0.0;
            double finalBill = 0.0;

            if (member == true && bill > 20)
            {
                discount = bill * 0.15;
                finalBill = bill - discount;
                Console.WriteLine("Intial Bill: " + bill);
                Console.WriteLine("Loyalty member? : " + loyalty);
                Console.WriteLine("Final Amount to Pay: " + finalBill);
            }
            else
            {
                finalBill = bill;
                Console.WriteLine("Intial Bill: " + bill);
                Console.WriteLine("Loyalty member? : " + loyalty);
                Console.WriteLine("Final Amount to Pay: " + finalBill);
            }

            //Medium - Task 9 - Day Name Finder
            Console.WriteLine("Enter a number between 1 and 7: ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4: 
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }       
        }
    }
}
