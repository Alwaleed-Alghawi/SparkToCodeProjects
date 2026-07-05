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

            
        }
    }
}
