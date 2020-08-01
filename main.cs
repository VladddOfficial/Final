using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Testing Bank Account");
    BankAccount b1 = new BankAccount(04,02,2017);
    b1.Name = "Arnold Schwarzenegger";
    //attempting to put more than 6 diggits
    b1.AccountNumber = "0008264"; 
    b1.AccountNumber = "008264"; 
    b1.Balance = 10000;
    b1.DisplayAccountInfo();
    b1.Withdraw(1000);
    //attempting to withdraw more than the balance
    b1.Withdraw(20000);
    Console.WriteLine("");


    Console.WriteLine("Testing Saving Account");
    SavingsAccount s1 = new SavingsAccount(01, 04, 2018);
    s1.Name = "Vlad Yarosh";
    s1.AccountNumber = "053945";
    s1.DisplayAccountInfo();
    Console.WriteLine("Date Created: " + s1.DateCreated);
    s1.Balance = 4000;
    s1.Withdraw(1000);
    s1.CalculateInterest();
    Console.WriteLine("");


    Console.WriteLine("Testing Checking Account");

    CheckingAccount c1 = new CheckingAccount(05, 15, 2005);
    c1.Name = "James Bond";
    c1.AccountNumber = "007";
    c1.DisplayAccountInfo();
    Console.WriteLine("Date Created: " + c1.DateCreated);
    c1.Balance = 5000;
    c1.CalculateInterest();
    c1.Withdraw(2000);
    Console.WriteLine("");

    Console.WriteLine("Trying to make Date Created a future date");
    Console.WriteLine("Today's day: " + DateTime.Today);
    Console.WriteLine("Setting: 11/17/2020");
    BankAccount b2 = new BankAccount(11,17,2020);

  }
}