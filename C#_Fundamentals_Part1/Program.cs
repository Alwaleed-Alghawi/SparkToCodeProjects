namespace C__Fundamentals_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Easy - Task 1
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
        }
}
}
