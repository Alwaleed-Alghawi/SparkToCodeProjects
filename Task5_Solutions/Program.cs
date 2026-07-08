namespace Task5_Solutions
{
    internal class Program
    {


        //Task 9 - CalculateAverage Function
        static double average(List<int> grades2)
        {
            int sumGrades = 0;
            foreach (int grade2 in grades2)
            {
                sumGrades += grade2;
            }
            return (double)sumGrades / grades2.Count;
        }

        //Task 9 - FindFirstFailing Function
        static int FindFirstFailing(List<int> grades2)
        {

            return grades2.Find(x => x < 60);
        }

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


            //Medium - Task 5 - Array Grade Range
            int[] studentGrades = new int[5];

            for (int i = 0; i < studentGrades.Length; i++)
            {
                Console.WriteLine("Enter 5 Grades: ");
                studentGrades[i] = int.Parse(Console.ReadLine());

            }

            studentGrades.Sort();
            int lowestGrade = studentGrades[0];
            int highestGrade = studentGrades[studentGrades.Length - 1];

            int sum = 0;
            foreach (int grade in studentGrades)
            {
                sum += grade;
            }

            double averageGrade = sum / 5.0;

            Console.WriteLine("Lowest Grade: " + lowestGrade);
            Console.WriteLine("Highest Grade: " + highestGrade);
            Console.WriteLine("Average Grade: " + averageGrade);


            //Medium - Task 6 - Filtered Shopping List
            List<string> shoppingList = new List<string>();

            while (true)
            {
                Console.WriteLine("Add item. When you're done type (done): ");
                string item = Console.ReadLine();

                if (item.ToLower() == "done")
                {
                    break;
                }
                else
                {
                    shoppingList.Add(item);
                }
            }

            Console.WriteLine("Shopping list before removal:");
            foreach (string i in shoppingList)
            {
                Console.WriteLine("- " + i);
            }

            Console.WriteLine("Enter the item name that you want to delete: ");
            string itemToDelete = Console.ReadLine();
            shoppingList.Remove(itemToDelete);

            Console.WriteLine("Shopping list after removal:");
            foreach (string i in shoppingList)
            {
                Console.WriteLine("- " + i);
            }


            //Medium - Task 7 - High score Podium
            List<int> highScores = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the 5 game scores: ");
                int score = int.Parse(Console.ReadLine());
                highScores.Add(score);
            }
            highScores.Sort();
            highScores.Reverse();

            Console.WriteLine("Top 3 High Scores:");
            Console.WriteLine("1st: " + highScores[0]);
            Console.WriteLine("2st: " + highScores[1]);
            Console.WriteLine("3st: " + highScores[2]);


            //Medium - Task 8 - Undo Last Action
            Stack<string> actions = new Stack<string>();

            while (true)
            {
                Console.Write("Type the action. Write (stop) to stop add actions: ");
                string action = Console.ReadLine();

                if (action.ToLower() == "stop")
                {
                    break;
                }
                else
                {
                    actions.Push(action);
                }
            }

            Console.WriteLine("After finishing, type (undo) to delete the action: ");
            string undoAction = Console.ReadLine();

            for (int i = 0; i < 2; i++)
            {

                if (actions.Count > 0)
                {
                    Console.WriteLine("Undone Tasks: " + actions.Pop());
                }
            }

            Console.WriteLine("Remaining actions on the stack: ");
            foreach (string remaining in actions)
            {
                Console.WriteLine("- " + remaining);
            }


            //Hard Task 9 - Grade Analyzer with Functions 

            Console.WriteLine("How many grades you want to enter?: ");
            int count = int.Parse(Console.ReadLine());

            List<int> grades2 = new List<int>();

            for(int i = 0; i < count; i++)
            {
                Console.Write("Enter the grade " + (i + 1) + ": ");
                int grade = int.Parse(Console.ReadLine());
                grades2.Add(grade);
            }

            //CalculateAverage Function Calling
            Console.WriteLine("The grades average: " + average(grades2));

            //FindFirstFailing Function Calling
            int firstFailing = FindFirstFailing(grades2);

            if (firstFailing == 0 && !grades2.Contains(0))
            {
                Console.WriteLine("No failing grades found.");
            }
            else
            {
                Console.WriteLine("First failing grade: " + firstFailing);
            }
        }



        
    }
}
