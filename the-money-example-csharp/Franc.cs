namespace Tdd.Money;

public class Franc: Money
{
    private readonly string _currency;
    
    public Franc(int amount) :  base(amount)
    {
        _currency = "CHF";
    }

    public override Money Times(int multiplier) =>
        new Franc(_amount * multiplier);

    public override string Currency => _currency;
}