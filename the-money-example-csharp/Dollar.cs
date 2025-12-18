namespace Tdd.Money;

public class Dollar: Money
{
    private readonly string _currency;
    
    public Dollar(int amount) :  base(amount)
    {
        _currency = "USD";
    }

    public override Money Times(int multiplier) =>
        new Dollar(_amount * multiplier);
    
    public override string Currency => _currency;
}