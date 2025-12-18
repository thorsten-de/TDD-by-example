namespace Tdd.Money;

public class Dollar: Money
{
    public Dollar(int amount) :  base(amount)
    {
    }

    public override Money Times(int multiplier) =>
        new Dollar(_amount * multiplier);
    
    public override string Currency => "USD";
}