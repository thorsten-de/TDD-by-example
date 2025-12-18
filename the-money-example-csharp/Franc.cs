namespace Tdd.Money;

public class Franc: Money
{
    public Franc(int amount) :  base(amount, "CHF")
    {
    }

    public override Money Times(int multiplier) =>
        new Franc(_amount * multiplier);

}