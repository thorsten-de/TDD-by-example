namespace Tdd.Money;

public class Franc: Money
{
    public Franc(int amount) :  base(amount)
    {
    }

    public Money Times(int multiplier) =>
        new Franc(_amount * multiplier);
}