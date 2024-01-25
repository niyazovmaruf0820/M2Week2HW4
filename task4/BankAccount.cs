namespace task4;

public class BankAccount
{
    int accountId;
    decimal balance;
    string OwnerName;
    bool isFrozen;
    public BankAccount( int accountId,  decimal balance,string ownerName)
    {
        this.accountId = accountId;
        this.balance = balance;
        OwnerName = ownerName;
    }
    public void Deposit(decimal amount)
    {
        if (amount > 0 && !isFrozen)
        {
            balance += amount;
            System.Console.WriteLine("Added");
        }
        else System.Console.WriteLine("Error");
    }
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && !isFrozen)
        {
            balance -= amount;
            System.Console.WriteLine("Added");
        }
        else System.Console.WriteLine("Error");
    }
    public void FreezeAccount()
    {
        isFrozen = true;
    }
    public void UnfreezeAccount()
    {
        isFrozen = false;
    }
}
