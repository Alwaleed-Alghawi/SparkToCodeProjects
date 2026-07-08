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


            //Easy - Task 2 - Dynamic To-Do List
            List<string> tasks = new List<string>();
            string task;

            while (true)
            {
                Console.WriteLine("Enter a task (or type 'exit' to stop): ");
                task = Console.ReadLine();

                if (task.ToLower() == "exit")
                {
                    break;

                }
                else
                { tasks.Add(task); }
            }

            Console.WriteLine("Your To-Do List:");
            foreach (string t in tasks)
            {
                Console.WriteLine("- " + t);
            }


            //Easy - Task 3 - Browsing History Stack
            Stack<string> history = new Stack<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a website URL: ");
                string url = Console.ReadLine();
                history.Push(url);
            }

            string previousUrl = history.Pop();
            Console.WriteLine("Previous URL: " + previousUrl);


            //Easy - Task 4 - Customer Service Queue
            Queue<string> line = new Queue<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a customer name: ");
                string customer = Console.ReadLine();
                line.Enqueue(customer);
            }

            string nextCustomer = line.Dequeue();
            Console.WriteLine("Customer served: " + nextCustomer);
        }
    }
}
