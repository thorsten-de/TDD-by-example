namespace Tdd.Money;

public class Dollar: Money
{
    public Dollar(int amount) :  base(amount)
    {
    }

    public Money Times(int multiplier) =>
        new Dollar(_amount * multiplier);
}