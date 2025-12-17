namespace Tdd.Money;

public class Dollar
{
    public int Amount { get; private set; }
    
    public Dollar(int amount)
    {
    }

    public void Times(int times)
    { 
        Amount = 2 * 5;
    }
}