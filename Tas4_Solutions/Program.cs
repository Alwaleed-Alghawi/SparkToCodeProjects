namespace Tas4_Solutions
{
    internal class Program
    {

        //Easy - Task 1 - Personalized Welcome Function
        public static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "! Great to have you here.");
        }


        //Easy - Task 2 - Square Number Function
        static int Square(int number)
        {
            return number * number;
        }


        //Easy - Task 3 - Celsius to Fahrenheit Function
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }


        //Easy - Task 4 - Fixed Menu Display Function
        static void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }


        //Medium - Task 5 - Even or Odd Function
        static bool IsEven(int number)
        {
            return (number % 2 == 0);
        }


        //Medium - Task 6 - Rectangle Area & Perimeter Functions
        static double CalculateArea(double length, double width)
        {
            return length * width;
        }



        //Medium - Task 7 - Grade Letter Function
        static string GetGradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }



        //Medium - Task 8 - Countdown Function
        static void Countdown(int start)
        {
            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");
        }


        //Hard - Task 9 - Overloaded Multiply Function
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        static void Main(string[] args)
        {
            //Easy - Task 1 - Personalized Welcome Function Calling
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            PrintWelcome(userName);


            //Easy - Task 2 - Square Number Function Calling
            Console.Write("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            int result = Square(userNumber);
            Console.WriteLine("Square: " + result);


            //Easy - Task 3 - Celsius to Fahrenheit Function Calling
            Console.Write("Enter temperature in Celsius: ");
            double celsiusValue = double.Parse(Console.ReadLine());
            double result1 = CelsiusToFahrenheit(celsiusValue);
            Console.WriteLine("Fahrenheit: " + result1);


            //Easy - Task 4 - Fixed Menu Display Function Calling
            DisplayMenu();


            //Medium - Task 5 - Even or Odd Function Calling
            Console.Write("Enter a number: ");
            int userNumber1 = int.Parse(Console.ReadLine());
            bool result2 = IsEven(userNumber);

            if (result2)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }


            //Medium - Task 6 - Rectangle Area & Perimeter Functions Calling
            Console.Write("Enter length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);


            //Medium - Task 7 - Grade Letter Function Calling
            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());
            string grade = GetGradeLetter(score);
            Console.WriteLine("Your grade is: " + grade);


            //Medium - Task 8 - Countdown Function Calling
            Console.Write("Enter a starting number: ");
            int startNumber = int.Parse(Console.ReadLine());
            Countdown(startNumber);



            //Hard - Task 9 - Overloaded Multiply Function
            int result3 = Multiply(4, 5);
            double result4 = Multiply(2.5, 3.0);
            int result5 = Multiply(2, 3, 4);

            Console.WriteLine("Multiply(int, int): " + result3);
            Console.WriteLine("Multiply(double, double): " + result4);
            Console.WriteLine("Multiply(int, int, int): " + result5);
        }
    }
}
