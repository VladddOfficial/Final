using System;

class SavingsAccount : BankAccount{
  public double balance;

  public double Balance{
    set{
      if(value >= 2500){
        balance = value;
        Console.WriteLine("Current Saving Balance is: " + balance);
        }
      else if (value < 2500) {Console.WriteLine("Balance cannot be less than $2500");}
    }
    get{return balance;}
  }

  public SavingsAccount() : base(){  }

   public SavingsAccount(int MM, int DD, int YYYY) : base(MM,DD,YYYY){  }



  public void CalculateInterest(){
    balance*=1.05;
    Console.WriteLine("Added interest and updated Saving balance\nCurrent Saving Balance: $" + balance);
  }

  public override void Withdraw(double amount){
    if (balance < 2500 ){ Console.WriteLine("Insufficient balance");}
    else if (balance >=2500) {
     balance-=amount;
      Console.WriteLine("$" + amount + " was withdrawn from the bank account\nCurrent saving balace: $" + balance);
      }
  }

}