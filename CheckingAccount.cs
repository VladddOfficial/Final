using System;

class CheckingAccount : BankAccount{


  public double balance;

  public CheckingAccount() : base(){  }

  public CheckingAccount(int MM, int DD, int YYYY) : base(MM,DD,YYYY){  }

  public double Balance{
    set{
      if(value >= 500){
        balance = value;
        Console.WriteLine("Current Checking Balance is: " + balance);
        }
      else if (value < 500) {Console.WriteLine("Balance cannot be less than $500");}
    }
    get{return balance;}
  }



  public override void Withdraw(double amount){
    if (balance < 2500 ){ Console.WriteLine("Insufficient balance");}
    else if (balance >=2500) {
     balance-=amount;
      Console.WriteLine("$" + amount + " was withdrawn from the saving account\nCurrent banace: $" + balance);
      }
  }

  public void CalculateInterest(){
    balance*=1.0075;
    Console.WriteLine("Added interest and updated Checking Balance\nCurrent Checking Balance: $" + balance);
  }

  
}