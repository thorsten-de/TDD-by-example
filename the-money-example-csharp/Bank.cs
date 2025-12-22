namespace Tdd.Money;

public class Bank
{
    public Money Reduce(IExpression source, string to)
    {
        Sum sum = (Sum)source;
        int amount = sum.augend.Amount + sum.addend.Amount;
        return new Money(amount, to);
    }
}