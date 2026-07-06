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
        }
    }
}
