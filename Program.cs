using System;
using System.Collections.Generic;

namespace FirstBankOfSuncoast
{
    class Transaction
    {
        public string Account { get; set; }
        public int Amount { get; set; }
        public string Type { get; set; }
        public DateTime TimeStamp { get; set; }
    }
    class Program
    {
        static void BannerMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // 1. Welcome to the app 
            BannerMessage("Welcome to The First Bank of Suncoast");

            // 2. Class Transaction// List of Transaction 
            var transaction = new List<Transaction>();
            // 3. App Should load past transactions from a file when it first starts (fileReader) (add later)
            // 4. While the User hasn’t chosen to QUIT: (Bool is false)
            var userHasChosenToQuit = false;
            while (userHasChosenToQuit == false)
            {
                // 5. Display the Menu Options:
                Console.WriteLine("Menu Options:");
                Console.WriteLine();
                // 	Deposit
                Console.WriteLine("Deposit");
                // 	Withdraw
                Console.WriteLine("Withdraw");
                // 	Balance 
                Console.WriteLine("Balance");
                // 	Transaction History 
                Console.WriteLine("Transaction History");
                // 	Quit
                Console.WriteLine("Quit");

                // 	Ask the user what they would like to choose?
                Console.WriteLine();
                Console.Write("Which of these Options would you like to choose? ");

                var choice = Console.ReadLine().ToUpper().Trim();

                // 6. If (Deposit):
                if (choice == "DEPOSIT")
                {
                    // 	Ask the user if they would like to choose Savings or Checking?
                    Console.Write("Would you like to Deposit money into your Savings or Checking? ");
                    var newAccount = Console.ReadLine();
                    // 	Ask how much they want to input into savings?
                    Console.Write($"How much money would you like to Deposit into {newAccount}");
                    var newAmount = int.Parse(Console.ReadLine());
                    var newTransaction = new Transaction()
                    {
                        Account = newAccount,
                        Amount = newAmount,
                        Type = "Deposit",
                        TimeStamp = DateTime.Now,
                    };
                    //   Add the amount to Account 
                    transaction.Add(newTransaction);
                    // 	Write all the transactions to the file (the four lines of code for the  fileWriter) (add later)
                }
                // 7. If (Withdraw):
                if (choice == "WITHDRAW")
                {
                    // 	Ask the user if they would like to choose Savings or Checking?
                    Console.Write("Would you like to Withdraw money into your Savings or Checking? ");
                    var answer = Console.ReadLine().ToUpper().Trim();
                    // 	If (Savings)
                    if (answer == "SAVINGS")
                    {
                        // 	Find Savings
                        var findSavings = transaction.Find(money => money.Account == "SAVINGS");
                        // 	Ask how much they want to withdraw from savings?
                        Console.Write("How much money would you like to Withdraw from your Savings? ");
                        var amount = int.Parse(Console.ReadLine());
                        // 		If there is enough money in account (account < 0)
                        if
                        {
                            // 			Remove money from savings
                            // 		Write all the transactions to the file (the four lines of code for the fileWriter)(add later)
                        }
                        // 		If there isn’t (account < 0)
                        // 			Do not remove money from savings
                    }
                    // 	If (Checking)
                    if (answer == "CHECKING")
                    {
                        // 	Find Checking
                        // 	Ask how much they want to withdraw from checking?
                        // If there is enough money in account
                        // 			Remove money from savings
                        // 		Write all the transactions to the file (the four lines of code 	for the fileWriter)
                        // 		If there isn’t (account < 0)
                        // 			Do not remove money from savings
                    }
                }
                // 8. If (Transaction History)
                if (choice == "TRANSACTION HISTORY")
                {
                    // 	Ask the user if they would like to choose Savings or Checking?
                    Console.Write("Would you like to view the Transaction History for your Savings or Checking? ");
                    var answer = Console.ReadLine().ToUpper().Trim();
                    // 	If (Savings)
                    if (answer == "SAVINGS")
                    {
                        // 	Print out the Transaction History for Savings
                    }
                    // 	If (Checking)
                    if (answer == "CHECKING")
                    {
                        // 	Print out the Transaction History for Checking
                    }
                }
                // 9. If (Balance)
                if (choice == "BALANCE")
                {
                    // 	Ask the user if they would like to choose Savings or Checking?
                    Console.Write("Would you like to view the Balance for your Savings or Checking? ");
                    var answer = Console.ReadLine().ToUpper().Trim();
                    // 	If (Savings) 
                    if (answer == "SAVINGS")
                    {
                        // 	See the Balance of the Savings
                    }
                    // 	If (Checking)
                    if (answer == "CHECKING")
                    {
                        // 	See the Balance of the Checking
                    }
                }
                // 10. If (Quit)
                if (choice == "QUIT")
                {
                    // 	Bool is True
                    userHasChosenToQuit = true;
                }
            }
            // 11. Say Goodbye
            BannerMessage("Thank you for visiting The First Bank of Suncoast. Goodbye.");
        }
    }
}
