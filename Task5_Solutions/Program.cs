namespace Task5_Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Easy - Task 1 - Fixed Grades Array
            int[] grades = new int[5];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Enter Grade: ");
                int grade = int.Parse(Console.ReadLine());
                grades[i] = grade;
            }

            foreach (int grade in grades)
            {
                Console.WriteLine("Grade: " + grade);
            }


            
        }
    }
}
