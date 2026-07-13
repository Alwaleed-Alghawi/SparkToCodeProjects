using System.Text.RegularExpressions;
using System.Transactions;
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

        // Case 16 - Parameterized constructor for Quick Account Opening
        public BankAccount(int accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HodlerName = holderName;
            Balance = balance;
        }

        public BankAccount() { }

        // Case 18 - Read-only property for Overdrawn Account Check
        public bool IsOverdrawn
        {
            get { return Balance < 0; }
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

        // Case 17 - Static field & method for Total Students Counter
        private static int totalStudents = 0;

        public static int GetTotalStudents()
        {
            return totalStudents;
        }

        // Increment the static counter whenever a Student is created
        public Student()
        {
            totalStudents++;
        }

        // Case 19 - Write-only property for Set Student Security PIN
        private string pin;

        public string PIN
        {
            set { pin = value; }
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
        static BankAccount account1 = new BankAccount { AccountNumber = 1244, HodlerName = "Alwaleed", Balance = 10000 };
        static BankAccount account2 = new BankAccount { AccountNumber = 3245, HodlerName = "Amani", Balance = 500 };


        static Student student1 = new Student { Grade = 70, Name = "Amani", Address = "Samail" };
        static Student student2 = new Student { Grade = 80, Name = "Alwaleed", Address = "Adam" };


        static Product product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
        static Product product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };


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
                    case 2: UpdateStudentAddress(); break;
                    case 3: MakeDeposit(); break;
                    case 4: MakeWithdrawal(); break;
                    case 5: ViewProductDetails(); break;
                    case 6: RegisterStudent(); break;
                    case 7: CompareAccountBalances(); break;
                    case 8: RestockProduct(); break;
                    case 9: TransferBetweenAccounts(); break;
                    case 10: UpdateStudentGrade(); break;
                    case 11: StudentReportCard(); break;
                    case 12: AccountHealthStatus(); break;
                    case 13: BulkSaleWithRevenue(); break;
                    case 14: ScholarshipEligibilityCheck(); break;
                    case 15: FullBalanceTopUpFlow(); break;
                    case 16: QuickAccountOpening(); break;
                    case 17: TotalStudentsCounter(); break;
                    case 18: OverdrawnAccountCheck(); break;
                    case 19: SetStudentSecurityPin(); break;
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


        // ------------------------------------------------ EASY ( Cases 1 - 5 ) ------------------------------------------------

        //Case 1 - View Account Details
        static void ViewAccountDetails()
        {
            //Single Responsability
            BankAccount account = ChooseAccount();
            double Balance = account.CheckBalance();
            Console.WriteLine("Balance: " + Balance);
        }

        //Case 2 - Update Student Address
        static void UpdateStudentAddress()
        {
            Student student = ChooseStudent();

            Console.Write("Enter the new Address: ");
            string newAddress = Console.ReadLine();

            student.Address = newAddress;
            Console.WriteLine("Address Updated - Your address is: " + student.Address);
        }

        //Case 3 - Make a Deposit
        static void MakeDeposit()
        {
            BankAccount account = ChooseAccount();
            Console.WriteLine("Enter Amount you want to Deposit: ");
            double amount = double.Parse(Console.ReadLine());

            account.Deposit(amount);

            Console.WriteLine($"Name: {account.HodlerName} - Balance {account.Balance}");
        }

        //Case 4 -  Make a Withdrawal
        static void MakeWithdrawal()
        {
            BankAccount account = ChooseAccount();
            Console.WriteLine("Enter Amount you want to Withdraw: ");
            double amount = double.Parse(Console.ReadLine());

            account.Withdraw(amount);

            Console.WriteLine($"Name: {account.HodlerName} - Balance {account.Balance}");
        }

        //Case 5 - View Product Details
        static void ViewProductDetails()
        {
            Product product = ChooseProduct();

            Console.WriteLine($"Total inventory: {product.GetInventoryValue()}");
        }

        // ------------------------------------------------ MEDIUM ( Cases 6 - 8 ) ------------------------------------------------

        //Case 6 - Register a Student
        static void RegisterStudent()
        {
            Student student = ChooseStudent();
            Console.WriteLine("Enter an email: ");
            string Email = Console.ReadLine();

            student.Register(Email);
        }

        //Case 7 - Compare Two Account Balances
        static void CompareAccountBalances()
        {
            if (account1.Balance > account2.Balance)
            {
                Console.WriteLine($"Account 1 has more Balance with: {account1.Balance} OMR");
            }
            else if (account1.Balance < account2.Balance)
            {
                Console.WriteLine($"Account 2 has more Balance with: {account2.Balance} OMR");
            }
            else
            {
                Console.WriteLine($"Both Accounts Are Equal: {account1.Balance} OMR - {account2.Balance} OMR");
            }
        }


        //Case 8 - Restock Product & Stock Level Check
        static void RestockProduct()
        {
            Product product = ChooseProduct();

            Console.WriteLine("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            product.Restock(quantity);


            if (product.StockQuantity < 10)
            {
                Console.WriteLine("Stock Level is Low!");
            }
            else if (product.StockQuantity >= 10 && product.StockQuantity <= 49)
            {
                Console.WriteLine("Stock Level is Moderate!");
            }
            else
            {
                Console.WriteLine("Stock Level is Well Stocked!");
            }
        }


        // ------------------------------------------------ Hard ( Cases 9 - 13 ) ------------------------------------------------

        //Case 9 - Transfer Between Accounts
        static void TransferBetweenAccounts()
        {
            Console.WriteLine("Enter Source Account: ");
            BankAccount sourceAccount = ChooseAccount();

            Console.WriteLine("Enter Destination Account: ");
            BankAccount destinationAccount = ChooseAccount();

            Console.WriteLine("Enter Amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (sourceAccount.Balance >= amount)
            {
                sourceAccount.Withdraw(amount);
                destinationAccount.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Transfer Failed: Insufficient funds.");
            }
        }


        //Case 10 - Update Student Grade (Validated)
        static void UpdateStudentGrade()
        {
            Student student = ChooseStudent();


            while (true)
            {
                Console.WriteLine("Enter a New Grade: ");
                string input = Console.ReadLine();

                try
                {
                    int newGrade = int.Parse(input);

                    if (newGrade < 0 || newGrade > 100)
                    {
                        Console.WriteLine("Number is out of 0-100 range. Try again.");
                        continue;
                    }

                    student.Grade = newGrade;
                    Console.WriteLine($"New Updated Grade: {student.Grade}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input: please enter a valid number. Try again.");
                }
            }
        }


        //Case 11 - Student Report Card
        static void StudentReportCard()
        {
            Student student = ChooseStudent();

            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Address: {student.Address}");
            Console.WriteLine($"Grade: {student.Grade}");

            string CalculateGrade()
            {
                if (student.Grade < 60)
                {
                    return "Fail.";
                }
                else
                {
                    return "Pass!";
                }

            }
            Console.WriteLine($"Result: {CalculateGrade()}");
        }


        //Case 12 - Account Health Status
        static void AccountHealthStatus()
        {
            BankAccount account = ChooseAccount();

            if (account.Balance < 50)
            {
                Console.WriteLine("Low Balance.");
            }
            else if (account.Balance > 50 && account.Balance < 1000)
            {
                Console.WriteLine("Healthy.");
            }
            else
            {
                Console.WriteLine("Premium.");
            }
        }

        //Case 13 - Bulk Sale With Revenue Calculation
        static void BulkSaleWithRevenue()
        {
            Product Product = ChooseProduct();

            Console.Write("Enter a quantity to Sell: ");
            int quantity = int.Parse(Console.ReadLine());

            if (Product.StockQuantity < quantity)
            {
                int neededQuantity = quantity - Product.StockQuantity;
                Console.WriteLine($"Not enough stock. You need {neededQuantity} more units.");
                return;
            }
            else
            {
                Product.Sell(quantity);
                double totalRevenue = quantity * Product.Price;
                Console.WriteLine($"Total Revenue: {totalRevenue}");
            }
        }

        //Case 14 - Scholarship Eligibility Check
        static void ScholarshipEligibilityCheck()
        {
            Student student = ChooseStudent();
            BankAccount account = ChooseAccount();

            bool gradeOk = student.Grade >= 80;
            bool balanceOk = account.Balance >= 100;

            if (gradeOk && balanceOk)
            {
                Console.WriteLine("You Are Eligible For Scholarship");
            }
            else if (!gradeOk && !balanceOk)
            {
                Console.WriteLine("You Are Not Eligible For Scholarship Due To Low Grade And Low Balance.");
            }
            else if (!gradeOk)
            {
                Console.WriteLine("You Are Not Eligible For Scholarship Due To Low Grade.");
            }
            else
            {
                Console.WriteLine("You Are Not Eligible For Scholarship Due To Low Balance.");
            }
        }

        //Case 15 - Full Balance Top-Up Flow
        static void FullBalanceTopUpFlow()
        {
            BankAccount account = ChooseAccount();

            if (account.Balance < 50)
            {
                double topUpAmount = 100 - account.Balance;
                double beforeTopUp = account.Balance;

                account.Deposit(topUpAmount);

                Console.WriteLine($"Balance Before: {beforeTopUp} OMR");
                Console.WriteLine($"Balance After: {account.Balance} OMR");
            }
            else
            {
                Console.WriteLine("No top-up needed. Balance is already 50 or above.");
            }

        }

        // ------------------------------------------------ ( Cases 16-19 ) - From Your Own Research ------------------------------------------------

        // Case 16 - Quick Account Opening [Parameterized Constructor]
        static void QuickAccountOpening()
        {
            Console.Write("Enter Account Number: ");
            int accNum = int.Parse(Console.ReadLine());

            Console.Write("Enter Holder Name: ");
            string holderName = Console.ReadLine();

            Console.Write("Enter Starting Balance: ");
            double balance = double.Parse(Console.ReadLine());

            BankAccount newAccount = new BankAccount(accNum, holderName, balance);

            Console.WriteLine($"Account Number: {newAccount.AccountNumber}");
            Console.WriteLine($"Holder Name: {newAccount.HodlerName}");
            Console.WriteLine($"Balance: {newAccount.Balance}");
        }

        // Case 17 - Total Students Counter [Static Fields & Methods]
        static void TotalStudentsCounter()
        {
            Console.WriteLine($"Total Students Created: {Student.GetTotalStudents()}");
        }

        // Case 18 - Overdrawn Account Check [Read-Only Property]
        static void OverdrawnAccountCheck()
        {
            BankAccount account = ChooseAccount();

            if (account.IsOverdrawn)
            {
                Console.WriteLine("This account is currently overdrawn.");
            }
            else
            {
                Console.WriteLine("This account is not overdrawn.");
            }
        }

        // Case 19 - Set Student Security PIN [Write-Only Property]
        static void SetStudentSecurityPin()
        {
            Student student = ChooseStudent();

            Console.Write("Enter a 4-digit PIN: ");
            string enteredPin = Console.ReadLine();

            student.PIN = enteredPin;

            Console.WriteLine("PIN has been set successfully.");
        }
    }
}