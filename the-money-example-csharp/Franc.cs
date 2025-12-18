namespace Tdd.Money;

public class Franc: Money
{
    public Franc(int amount) :  base(amount)
    {
    }

    public override Money Times(int multiplier) =>
        new Franc(_amount * multiplier);

    public override string Currency => "CHF";
}