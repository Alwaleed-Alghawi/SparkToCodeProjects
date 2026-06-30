namespace CSharp_Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a C# program to print Hello and your name in a separate line.

            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter your Age: ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your salary: ");
            float sal = float.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + userName + ", Your age is " + userAge + ", and your salary is " + sal);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //2. Write a C# program to print the sum, multiply, subtract, divide and remainder of two numbers.

            Console.WriteLine("Please enter first number: ");
            float firstNo = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number: ");
            float secondNo = float.Parse(Console.ReadLine());

            float additionResult = firstNo + secondNo;
            float subtractResult = firstNo - secondNo;
            float multiplicationResult = firstNo * secondNo;
            float divisionResult = firstNo / secondNo;
            float reminderResult = firstNo % secondNo;

            Console.WriteLine("Addition Result: " + additionResult);
            Console.WriteLine("Subtraction Result: " + subtractResult);
            Console.WriteLine("Multiplication Result: " + multiplicationResult);
            Console.WriteLine("Division Result: " + divisionResult);
            Console.WriteLine("Reminder Result: " + reminderResult);

            bool resutl = firstNo > secondNo;

            Console.WriteLine("Is first number greater than second number? " + resutl);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //3. Write a C# program to check whether a number is positive or negative.

            Console.WriteLine("Enter your degree: ");
            float degree = float.Parse(Console.ReadLine());

            if (degree >= 0 && degree < 50)
            {
                Console.WriteLine("You failed");
            }
            else if (degree >= 50 && degree < 60)
            {
                Console.WriteLine("You passed with grade D");
            }
            else if (degree >= 60 && degree < 70)
            {
                Console.WriteLine("You passed with grade C");
            }
            else if (degree >= 70 && degree < 80)
            {
                Console.WriteLine("You passed with grade B");
            }
            else if (degree >= 80 && degree >= 90)
            {
                Console.WriteLine("You passed with grade A");
            }
            else
            {
                Console.WriteLine("Invalid degree entered");
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //4. Write a C# program to create a simple calculator to add, subtract, multiply and divide using switch case.
            Console.WriteLine("Welcome to main menu: ");
            Console.WriteLine("1.Deposite");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3,Balance check");

            Console.WriteLine("Please enter your choice: ");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                        Console.WriteLine("Diposited"); 
                    break;

                case 2:
                    Console.WriteLine("Withdrawed");
                    break;

                case 3:
                    Console.WriteLine("Balance");
                    break;

                default: Console.WriteLine("Please enter a valid option");
                    break;
            }
        }
    }
}
