using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Task6_OOP_Solutions
{

    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HodlerName { get; set; }

        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;

            SendEmail();
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                Balance -= amount;

                SendEmail();
            }
        }

        public double CheckBalance()
        {
            PrintInformation();

            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine("Name: " + HodlerName);
            Console.WriteLine("Balance: " + Balance);
        }

        private void SendEmail()
        {
            Console.WriteLine("Email Notification Sent.");
        }
    }

    public class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email { get; set; }
        int age { get; set; }

        public void Register(string Email)
        {
            email = Email;

            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Email Notification sent.");
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock quantity.");
            }

            LogTransaction();
        }

        public void Restock(int quantity)
        {
            StockQuantity += quantity;

            LogTransaction();
        }

        public double GetInventoryValue()
        {
            PrintDetails();

            return Price * StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Stock Quantity: {StockQuantity}");
        }

        private void LogTransaction()
        {
            Console.WriteLine("Transaction logged.");
        }
    }


    public class Program
    {
        //Instantiate exactly two BankAccount objects, two Student objects, and two Product objects as individual,
        //separately named objects
        static  BankAccount account1 = new BankAccount { AccountNumber = 1244 , HodlerName = "Alwaleed", Balance = 120 };
        static  BankAccount account2 = new BankAccount { AccountNumber = 3245 , HodlerName = "Amani", Balance = 500 };


        static  Student student1 = new Student { Grade = 90 , Name = "Amani" , Address = "Samail" };
        static  Student student2 = new Student { Grade = 80 , Name = "Alwaleed" , Address = "Adam" };


        static  Product product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
        static  Product product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };


        static void Main(string[] args)
        {
            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1: ViewAccountDetails(); break;
                    //case 2: UpdateStudentAddress(); break;
                    //case 3: MakeDeposit(); break;
                    //case 4: MakeWithdrawal(); break;
                    //case 5: ViewProductDetails(); break;
                    //case 6: RegisterStudent(); break;
                    //case 7: CompareAccountBalances(); break;
                    //case 8: RestockProduct(); break;
                    //case 9: TransferBetweenAccounts(); break;
                    //case 10: UpdateStudentGrade(); break;
                    //case 11: StudentReportCard(); break;
                    //case 12: AccountHealthStatus(); break;
                    //case 13: BulkSaleWithRevenue(); break;
                    //case 14: ScholarshipEligibilityCheck(); break;
                    //case 15: FullBalanceTopUpFlow(); break;
                    //case 16: QuickAccountOpening(); break;
                    //case 17: TotalStudentsCounter(); break;
                    //case 18: OverdrawnAccountCheck(); break;
                    //case 19: SetStudentSecurityPin(); break;
                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }

                Console.WriteLine("Press any key");
                Console.ReadKey();
                Console.Clear();

            }
        }

        // ------------------------------------------------ Helpers ------------------------------------------------

        static BankAccount ChooseAccount()
        {
            Console.Write("Choose account (1 or 2): ");
            string input = Console.ReadLine();
            if (input == "2")
            {
                return account2;
            }
            return account1;
        }

        static Student ChooseStudent()
        {
            Console.Write("Choose Student (1 or 2): ");
            string input = Console.ReadLine();
            if (input == "2")
            {
                return student2;
            }
            return student1;
        }

        static Product ChooseProduct()
        {
            Console.Write("Choose product (1 or 2): ");
            string input = Console.ReadLine();
            if (input == "2")
            {
                return product2;
            }
            return product1;
        }


        // ------------------------------------------------ EASY ( Cases 1 -5 ) ------------------------------------------------
        
        //Case 1 - View Account Details
        static void ViewAccountDetails()
        {
            //Single Responsability
            BankAccount account = ChooseAccount();
            double Balance  = account.CheckBalance();
            Console.WriteLine("Balance: " + Balance);
        }

        
    }
}