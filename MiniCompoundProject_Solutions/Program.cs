using System;
using System.Collections.Generic;
using System.Transactions;
namespace BankingSystemApp
{
    internal class Program
    {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. Find Richest Customer");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                    
                catch (Exception )
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        ListAllAccounts();
                        break;
                    case 7:
                        FindRichestCustomer();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.
        static void AddAccount()
        {
            // TODO: implement this service (see Section 3 requirements)
            //Service 1 - Add New Account
            Console.WriteLine("Welcome to Spark Bank!");

            Console.Write("Please Enter you full name: ");
            string accName = Console.ReadLine();

            Console.Write("Please Enter the account number: ");
            string accountNum = Console.ReadLine();

            if (accountNumbers.Contains(accountNum))
            {
                Console.WriteLine("Error: Account Already exists.");
                return;
            }

            Console.Write("Please Enter initial deposit amount: ");
            double intialAmount = double.Parse(Console.ReadLine());

            if (intialAmount < 0) 
            {
                Console.WriteLine("Error: Amount is less than zero.");
                return;
            }

            customerNames.Add(accName);
            accountNumbers.Add(accountNum);
            balances.Add(intialAmount);

            Console.WriteLine($"Account created Successfully! Name: {accName} - Number: {accountNum} - Starting balance: {intialAmount}");
        }
        static void DepositMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
            //Service 2 - Desposite Money
            Console.Write("Please Enter you account number: ");
            string accountNum = Console.ReadLine();

            int index = accountNumbers.FindIndex(a => a == accountNum);

            if (index == -1) 
            {
                Console.WriteLine("Error: Account not found.");
                return;
            }

            Console.Write("Account Found, Please Enter the amount to Deposit: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount <= 0) 
            {
                Console.WriteLine("Amount can't be zero or less.");
                return;
            }

            balances[index] = amount;

            Console.WriteLine($"Deposit successful! {customerNames[index]}'s updated balance is {balances[index]}.");

        }
        static void WithdrawMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
            //Service 3 - Withdraw Money
            Console.Write("Please Enter you account number: ");
            string accountNum = Console.ReadLine();

            int index = accountNumbers.FindIndex(a => a == accountNum);

            if (index == -1)
            {
                Console.WriteLine("Error: Account not found.");
                return;
            }

            Console.Write("Account found! - Please Enter the amount to Withdraw: ");
            double balance = double.Parse(Console.ReadLine());

            if (balance <= 0)
            {
                Console.WriteLine("Error: Amount cannot be zero or less.");
                return;
            }
            else if (balance > balances[index])
            {
                Console.WriteLine("Error: Not Enough funds.");
                return;
            }
            else
            {
                Console.WriteLine("Withdrawing Money...");
                double newBalance = balances[index] - balance;
                Console.WriteLine("Your current balance is: " + newBalance);
            }
        }
        static void ShowBalance()
        {
            // TODO: implement this service (see Section 3 requirements)
            //Service 4 - Show Balance
            Console.Write("Please Enter you account number: ");
            string accountNum = Console.ReadLine();

            int index = accountNumbers.FindIndex(a => a == accountNum);

            if (index == -1)
            {
                Console.WriteLine("Error: Account not found.");
                return;
            }

            Console.WriteLine("Account found! - Youe Details are: ");
            Console.WriteLine($"Name: {customerNames[index]} ");
            Console.WriteLine($"Account Number: {accountNumbers[index]} ");
            Console.WriteLine($"Balance: {balances[index]:C} ");
        }
        static void TransferAmount()
        {
            // TODO: implement this service (see Section 3 requirements)
            //Service 5 - Transfer Amount
            Console.Write("Please Enter you account number: ");
            string accountNum = Console.ReadLine();

            int index = accountNumbers.FindIndex(a => a == accountNum);

            if (index == -1)
            {
                Console.WriteLine("Error: Account not found.");
                return;
            }

            Console.Write("Please Enter Recevier account number: ");
            string accountNumRecevier = Console.ReadLine();

            int index1 = accountNumbers.FindIndex(b => b == accountNumRecevier);

            if (index1 == -1)
            {
                Console.WriteLine("Error: Recevier Account not found.");
                return;
            }

            Console.Write("Please Enter the balance you wish to transfere: ");
            double transfereAmount = double.Parse(Console.ReadLine());

            if (balances[index] < transfereAmount)
            {
                Console.WriteLine("Error: Insufficient balance.");
                return;
            }
            else
            {
                double newBalance = balances[index] - transfereAmount;
                double newReceiverBalance = balances[index1] + transfereAmount;

                balances[index] = newBalance;
                balances[index1] = newReceiverBalance;

                Console.WriteLine("Transfered succesfully.");
                Console.WriteLine($"Your Account Balance: {balances[index]}");
                Console.WriteLine($"Receiver's Account Balance: {balances[index1]}");
            }
        }
        // TODO: write two more void, no-parameter functions here for
        // your own custom services (option 6 and option 7)
        //Service 6 - List All Accounts
        static void ListAllAccounts()
        {
            if (customerNames.Count == 0)
            {
                Console.WriteLine("No accounts have been created yet.");
                return;
            }

            Console.WriteLine("===== All Accounts =====");
            for (int i = 0; i < customerNames.Count; i++)
            {
                Console.WriteLine($"Name: {customerNames[i]} - Account Number: {accountNumbers[i]} - Balance: OMR {balances[i]:N3}");
            }
        }

        //Service 7 - Find the Richest Customer
        static void FindRichestCustomer()
        {
            if (customerNames.Count == 0)
            {
                Console.WriteLine("No accounts have been created yet.");
                return;
            }

            int richestIndex = 0;

            for (int i = 1; i < balances.Count; i++)
            {
                if (balances[i] > balances[richestIndex])
                {
                    richestIndex = i;
                }
            }

            Console.WriteLine("===== Richest Customer =====");
            Console.WriteLine($"Name: {customerNames[richestIndex]}");
            Console.WriteLine($"Account Number: {accountNumbers[richestIndex]}");
            Console.WriteLine($"Balance: OMR {balances[richestIndex]:N3}");
        }


    }
}