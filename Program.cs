using System;
using System.Collections.Generic;
using System.Transactions;

namespace FirstBankOfSuncoast
{
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
            // 	Ask the user if they would like to choose Savings or Checking?
            // 	Ask how much they want to input into savings?
            //   Add the amount to Account 

            // 	Write all the transactions to the file (the four lines of code for the  fileWriter)



            // 7. If (Withdraw):
            // 	Ask the user if they would like to choose Savings or Checking?

            // 	If (Savings)
            // 	Find Savings
            // 	Ask how much they want to withdraw from savings?
            // 		If there is enough money in account 
            // 			Remove money from savings
            // 		Write all the transactions to the file (the four lines of code for the fileWriter)
            // 		If there isn’t (account < 0)
            // 			Do not remove money from savings

            // 	If (Checking)
            // 	Find Checking
            // 	Ask how much they want to withdraw from checking?
            // If there is enough money in account
            // 			Remove money from savings
            // 		Write all the transactions to the file (the four lines of code 	for the fileWriter)
            // 		If there isn’t (account < 0)
            // 			Do not remove money from savings


            // 8. If (Transaction History)
            // 	Ask the user if they would like to choose Savings or Checking?
            // 	If (Savings)
            // 	Print out the Transaction History for Savings
            // 	If (Checking)
            // 	Print out the Transaction History for Checking

            // 9. If (Balance)
            // 	Ask the user if they would like to choose Savings or Checking?
            // 	If (Savings) 
            // 	See the Balance of the Savings
            // 	If (Checking)
            // 	See the Balance of the Checking

            // 10. If (Quit)
            // 	Bool is True

            // 11. Say Goodbye
            BannerMessage("Thank you for visiting The First Bank of Suncoast. Goodbye.");
        }
    }
}
