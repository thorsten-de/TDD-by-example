namespace Tdd.Money;

public class Bank
{
    public Money Reduce(IExpression source, string to) => source.Reduce(to);
}