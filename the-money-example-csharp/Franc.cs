namespace Tdd.Money;

public class Franc: Money
{
    public Franc(int amount, string currency) :  base(amount, currency)
    {
    }

    public override Money Times(int multiplier) =>
        new Franc(_amount * multiplier, Currency);

}