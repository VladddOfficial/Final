using System;

class BankAccount{

public string accountnumber;
public double balance;
public virtual DateTime datecreated{set;get;}


  public string AccountNumber{

    get{return accountnumber;}

    set{
      if (value.Length > 0 && value.Length <= 6){
        accountnumber = value;
      }
      else Console.WriteLine ("The Account Number is limited to 6 characters");
    }
    
  }

  public string Name{set;get;}

  public double Balance{
    set{
      if (value > 0){
        balance = value;
      }
      else Console.WriteLine("Balance cannot be negative");
    }
    get{return balance;}
  } 


  public virtual DateTime DateCreated{
    get {return datecreated;}
    set{
      if ( DateTime.Today.Year < value.Year
       || (DateTime.Today.Year == value.Year && DateTime.Today.Month < value.Month) || (DateTime.Today.Year == value.Year && DateTime.Today.Month == value.Month && DateTime.Today.Day < value.Day)){
        Console.WriteLine("Date Created cannot be a future date");
      }
      else if ( DateTime.Today.Year > value.Year
       || (DateTime.Today.Year == value.Year && DateTime.Today.Month > value.Month) || (DateTime.Today.Year == value.Year && DateTime.Today.Month == value.Month && DateTime.Today.Day > value.Day)){
        datecreated = value;
      }
    } 
  }

  public BankAccount(){
    datecreated = DateTime.Today;
  }

  public BankAccount (int MM, int DD, int YYYY){
    DateCreated = Convert.ToDateTime(MM+"/"+DD+"/"+YYYY);
  }

  public void DisplayAccountInfo(){
    Console.WriteLine("Account Number: " + accountnumber);
    Console.WriteLine("Name: " + Name);
    Console.WriteLine("Balance: " + balance);
  }

  public void Deposit(double amount){
    balance+=amount;
    Console.WriteLine("$"+amount +" was added to the bank account\nCurrent banance: $" + balance);
  }
  
  public virtual void Withdraw(double amount){
    
    if(amount > balance){
      Console.WriteLine("Not enought funds to Withdraw $" + amount + "\nCurrent banace: $" + balance);
    }
    else if (balance >= amount){ balance-=amount;
    Console.WriteLine("$" + amount + " was withdrawn from the bank account\nCurrent banace: $" + balance);
    }
    
  }

  public void CalculateInterest(){
    Console.WriteLine("This method will calculate Interest");
  }

}