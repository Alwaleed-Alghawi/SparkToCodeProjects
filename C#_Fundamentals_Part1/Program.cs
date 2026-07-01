using System.Runtime.CompilerServices;

namespace C__Fundamentals_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Easy - Task 1 - Personal Info Card
            //string name = "Alwaleed";
            //int age = 22;
            //double height = 1.85;
            //bool student = true;

            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("Height: " + height);
            //if (student)
            //{
            //    Console.WriteLine("You are a student.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not a student.");
            //}


            ////Easy - Task 2 - Rectangle Calculator
            //Console.WriteLine("Enter lenght: ");
            //float length = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter width: ");
            //float width = float.Parse(Console.ReadLine());

            //float area = length * width;
            //float perimeter = 2 * (length + width);

            //Console.WriteLine("Area of the Rectangle: " + area);
            //Console.WriteLine("Perimeter of the Rectangle: " + perimeter);


            ////Easy - Task 3 - Even or Odd Checker
            //Console.WriteLine("Enter a whole number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number " + number + " is even");
            //}
            //else if (number % 2 != 2)
            //{
            //    Console.WriteLine("The number " + number + " is odd");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid number");
            //}


            ////Easy - Task 4 - Voting Eligibility
            //Console.WriteLine("Enter your Age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Do you have a valid ID? (yes/no): ");
            //string id = Console.ReadLine();

            //bool validId = (id == "yes");

            //if (age >= 18 && validId)
            //{
            //    Console.WriteLine("You are Eligible To Vote!");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, You are not Eligible To Vote.");
            //}

            ////Easy - Task 5 - Grade Letter Lookup
            //Console.WriteLine("Enter your grade (Letters only): ");
            //char grade = char.Parse(Console.ReadLine());

            //switch (grade)
            //{
            //    case 'A': 
            //        Console.WriteLine("A > Excellent");
            //        break;

            //    case 'B':
            //        Console.WriteLine("B > Very Good");
            //        break;

            //    case 'C':
            //        Console.WriteLine("C > Good");
            //        break;

            //    case 'D':
            //        Console.WriteLine("D > Pass");
            //        break;

            //    case 'F':
            //        Console.WriteLine("F > Fail");
            //        break;
            //}

            //Medium - Task 1 - Temperature Converter
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
        }
    }
}
