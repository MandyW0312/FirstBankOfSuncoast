﻿using System;
using System.Collections.Generic;
using System.Linq;

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
            BannerMessage("Welcome to The First Bank of Suncoast");

            var transactions = new List<Transaction>(){
            new Transaction()
            {
                Account = "SAVINGS",
                Type = "Deposit",
                Amount = 500,
                TimeStamp = DateTime.Now,
            },
            new Transaction()
            {
                Account = "CHECKING",
                Type = "Deposit",
                Amount = 400,
                TimeStamp = DateTime.Now,
            },
            new Transaction()
            {
                Account = "SAVINGS",
                Type = "Withdraw",
                Amount = 8,
                TimeStamp = DateTime.Now,
            }
            };
            // 3. App Should load past transactions from a file when it first starts (fileReader) (add later)
            var userHasChosenToQuit = false;
            while (userHasChosenToQuit == false)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine();
                Console.WriteLine("Deposit");
                Console.WriteLine("Withdraw");
                Console.WriteLine("Balance");
                Console.WriteLine("Transaction History");
                Console.WriteLine("Quit");


                Console.WriteLine();
                Console.Write("Which of these Options would you like to choose? ");

                var choice = Console.ReadLine().ToUpper().Trim();

                if (choice == "DEPOSIT")
                {
                    Console.Write("Would you like to Deposit money into your Savings or Checking? ");
                    var newAccount = Console.ReadLine().ToUpper().Trim();
                    Console.Write($"How much money would you like to Deposit into {newAccount}? ");
                    var newAmount = int.Parse(Console.ReadLine());

                    var newTransaction = new Transaction()
                    {
                        Account = newAccount,
                        Amount = newAmount,
                        Type = "Deposit",
                        TimeStamp = DateTime.Now,
                    };
                    transactions.Add(newTransaction);
                    // 	Write all the transactions to the file (the four lines of code for the  fileWriter) (add later)
                }

                if (choice == "WITHDRAW")
                {
                    Console.Write("Would you like to Withdraw money from your Savings or Checking? ");
                    var answer = Console.ReadLine().ToUpper().Trim();

                    if (answer == "SAVINGS")
                    {
                        var findSavings = transactions.Where(money => money.Account == "SAVINGS");
                        var findDeposit = findSavings.Where(money => money.Type == "Deposit").Sum(money => money.Amount);
                        var findWithdraw = findSavings.Where(money => money.Type == "Withdraw").Sum(money => money.Amount);

                        var difference = (findDeposit - findWithdraw);


                        Console.Write("How much money would you like to Withdraw from your Savings? ");
                        var withdrawAmount = int.Parse(Console.ReadLine());
                        if (difference < withdrawAmount)
                        {
                            Console.WriteLine($"Insufficient funds in {answer}, you will not be able to Withdraw {withdrawAmount}");
                        }
                        if (difference > withdrawAmount)
                        {
                            var newTransaction = new Transaction()
                            {
                                Account = answer,
                                Amount = withdrawAmount,
                                Type = "Withdraw",
                                TimeStamp = DateTime.Now,
                            };
                            transactions.Add(newTransaction);
                            // 	Write all the transactions to the file (the four lines of code for the  fileWriter) (add later)
                        }
                    }

                    if (answer == "CHECKING")
                    {
                        var findChecking = transactions.Where(money => money.Account == "CHECKING");
                        var findDeposit = findChecking.Where(money => money.Type == "Deposit").Sum(money => money.Amount);
                        var findWithdraw = findChecking.Where(money => money.Type == "Withdraw").Sum(money => money.Amount);

                        var difference = (findDeposit - findWithdraw);
                        Console.Write("How much money would you like to Withdraw from your Savings? ");
                        var withdrawAmount = int.Parse(Console.ReadLine());
                        if (difference < withdrawAmount)
                        {
                            Console.WriteLine($"Insufficient funds in {answer}, you will not be able to Withdraw {withdrawAmount}");
                        }
                        if (difference > withdrawAmount)
                        {
                            var newTransaction = new Transaction()
                            {
                                Account = answer,
                                Amount = withdrawAmount,
                                Type = "Withdraw",
                                TimeStamp = DateTime.Now,
                            };
                            transactions.Add(newTransaction);
                            // 	Write all the transactions to the file (the four lines of code for the  fileWriter) (add later)
                        }
                    }
                }

                if (choice == "TRANSACTION HISTORY")
                {
                    Console.Write("Would you like to view the Transaction History for your Savings or Checking? ");
                    var answer = Console.ReadLine().ToUpper().Trim();

                    if (answer == "SAVINGS")
                    {
                        var findSavings = transactions.Where(money => money.Account == "SAVINGS");
                        foreach (var save in findSavings)
                        {
                            Console.WriteLine($"Your Transaction History: Your {save.Account} was {save.Type} for the amount of {save.Amount}. ");
                        }
                    }

                    if (answer == "CHECKING")
                    {
                        var findChecking = transactions.Where(money => money.Account == "SAVINGS");
                        foreach (var check in findChecking)
                        {
                            Console.WriteLine($"Your Transaction History: Your {check.Account} was {check.Type} for the amount of {check.Amount}. ");
                        }
                    }
                }

                if (choice == "BALANCE")
                {
                    Console.Write("Would you like to view the Balance for your Savings or Checking? ");
                    var answer = Console.ReadLine().ToUpper().Trim();

                    if (answer == "SAVINGS")
                    {
                        var findSavings = transactions.Where(money => money.Account == "SAVINGS");
                        var findDeposit = findSavings.Where(money => money.Type == "Deposit").Sum(money => money.Amount);
                        var findWithdraw = findSavings.Where(money => money.Type == "Withdraw").Sum(money => money.Amount);

                        var difference = (findDeposit - findWithdraw);
                        Console.WriteLine($"Your Balance in {answer} is {difference}.");
                    }

                    if (answer == "CHECKING")
                    {
                        var findChecking = transactions.Where(money => money.Account == "CHECKING");
                        var findDeposit = findChecking.Where(money => money.Type == "Deposit").Sum(money => money.Amount);
                        var findWithdraw = findChecking.Where(money => money.Type == "Withdraw").Sum(money => money.Amount);

                        var difference = (findDeposit - findWithdraw);
                        Console.WriteLine($"Your Balance in {answer} is {difference}.");
                    }
                }

                if (choice == "QUIT")
                {
                    userHasChosenToQuit = true;
                }
            }

            BannerMessage("Thank you for visiting The First Bank of Suncoast. Goodbye.");
        }
    }
}
