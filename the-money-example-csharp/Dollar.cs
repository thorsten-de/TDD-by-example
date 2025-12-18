namespace Tdd.Money;

public class Dollar: Money
{
    
    public Dollar(int amount, string currency) :  base(amount, "USD")
    {
    }

    public override Money Times(int multiplier) =>
        Dollar(_amount * multiplier);
    
}