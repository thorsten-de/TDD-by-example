namespace Tdd.Money;

public class Bank
{
    public Money Reduce(IExpression source, string to)
    {
        Sum sum = (Sum)source;
        return sum.Reduce(to);
    }
}