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
            int age2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you have a valid ID? (yes/no): ");
            string id = Console.ReadLine();

            bool validId = (id == "yes");

            if (age2 >= 18 && validId)
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
            int age3 = int.Parse(Console.ReadLine());

            double ticketPrice = 0.0;

            if (age3 <= 12)
            {
                ticketPrice = 2.000;
                Console.WriteLine("You are a Child, The price of the ticket is " + ticketPrice + " OMR.");
            }
            else if (age3 <= 59)
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

            //Medium - Task 10 - Mini Calculator
            Console.WriteLine("Enter an Operator (+, -, *, /, or %): ");
            char op = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter First Number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Result: " + (firstNumber + secondNumber));
                    break;

                case '-':
                    Console.WriteLine("Result: " + (firstNumber - secondNumber));
                    break;

                case '*':
                    Console.WriteLine("Result: " + (firstNumber * secondNumber));
                    break;

                case '/':
                    if (secondNumber != 0)
                    {
                        Console.WriteLine("Result: " + (firstNumber / secondNumber));

                    }
                    else
                    {
                        Console.WriteLine("Cannot devide by zero");
                    }
                    break;

                case '%':
                    if (secondNumber != 0)
                    {
                        Console.WriteLine("Result: " + (firstNumber % secondNumber));

                    }
                    else
                    {
                        Console.WriteLine("Cannot devide by zero");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            //Hard - Task 11 - Loan Eligibility System
            Console.Write("Enter your Age: ");
            int age4 = int.Parse(Console.ReadLine());

            Console.Write("Enter your monthly income: ");
            double income = double.Parse(Console.ReadLine());

            Console.Write("Do you have an existing income (yes/no): ");
            string existingIncome = Console.ReadLine();

            bool hasExIncome = (existingIncome == "yes");

            if (age4 >= 21 && age4 <= 60 && income >= 400 && !hasExIncome)
            {
                Console.WriteLine("Your Eligibale to get a laon");
            }
            else
            {
                Console.WriteLine("Sorry, You are not Eligible to get a loan");
                if (age4 < 21)
                {
                    Console.WriteLine("You are below the age");
                }

                if (age4 > 60)
                {
                    Console.WriteLine("You are above the age");
                }

                if (income < 400)
                {
                    Console.WriteLine("Your income is below 400");
                }

                if (hasExIncome)
                {
                    Console.WriteLine("You already have a loan");
                }
            }

            //Hard - Task 12 - Shipping Cost Calculator
            Console.Write("Enter the regoin  code 'A' for local, 'B' for national, 'C' for international: ");
            char regoin = char.Parse(Console.ReadLine());

            Console.Write("Enter the package weight: ");
            int weight = int.Parse(Console.ReadLine());

            double baseCost = 0.0;
            double shippingCost = 0.0;
            double extraCharge = 0.0;

            switch (regoin)
            {
                case 'A':
                    baseCost = 1.000;
                    if (weight > 5 && weight < 10)
                    {
                        extraCharge = 2.000;
                        shippingCost = baseCost + extraCharge;
                    }
                    else if (weight > 10)
                    {
                        extraCharge = 5.000;
                        shippingCost = baseCost + extraCharge;
                    }
                    else
                    {
                        shippingCost = baseCost + extraCharge;
                    }

                    Console.WriteLine("Base Cost: " + baseCost);
                    Console.WriteLine("Extra charge:  " + extraCharge);
                    Console.WriteLine("Shipping Cost: " + shippingCost);
                    break;

                case 'B':
                    baseCost = 3.000;
                    if (weight > 5 && weight < 10)
                    {
                        extraCharge = 2.000;
                        shippingCost = baseCost + extraCharge;
                    }
                    else if (weight > 10)
                    {
                        extraCharge = 5.000;
                        shippingCost = baseCost + extraCharge;
                    }
                    else
                    {
                        shippingCost = baseCost + extraCharge;
                    }

                    Console.WriteLine("Base Cost: " + baseCost);
                    Console.WriteLine("Extra charge:  " + extraCharge);
                    Console.WriteLine("Shipping Cost: " + shippingCost);
                    break;

                case 'C':
                    baseCost = 7.000;
                    if (weight > 5 && weight < 10)
                    {
                        extraCharge = 2.000;
                        shippingCost = baseCost + extraCharge;
                    }
                    else if (weight > 10)
                    {
                        extraCharge = 5.000;
                        shippingCost = baseCost + extraCharge;
                    }
                    else
                    {
                        shippingCost = baseCost + extraCharge;
                    }

                    Console.WriteLine("Base Cost: " + baseCost);
                    Console.WriteLine("Extra charge:  " + extraCharge);
                    Console.WriteLine("Shipping Cost: " + shippingCost);
                    break;

                default:
                    Console.WriteLine("Invalid regoin code");
                    break;
            }

            //Hard - Task 13 - Tringle Type Classifier
            Console.Write("Enter the first side of the triangle: ");
            int side1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second side of the triangle: ");
            int side2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third side of the triangle: ");
            int side3 = int.Parse(Console.ReadLine());

            int firstTwoSides = side1 + side2;
            int secondTwoSides = side1 + side3;
            int thirdTwoSides = side2 + side3;

            if (firstTwoSides > side3 && secondTwoSides > side2 && thirdTwoSides > side1)
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("Equilateral");
                }

                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("Scalene");
                }
            }
            else
            {
                Console.WriteLine("Not a valid triangle");
            }

            //Advanced - Task 14 - Online Store Checkout 

        }
    }
}

