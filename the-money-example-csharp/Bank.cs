namespace Tdd.Money;

public class Bank
{
    public Money Reduce(IExpression source, string to) => source.Reduce(this, to);

    public void AddRate(string from, string to, int rate)
    {
    }
}