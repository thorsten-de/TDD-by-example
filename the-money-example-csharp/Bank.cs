namespace Tdd.Money;

public class Bank
{
    public Money Reduce(IExpression source, string to)
    {
        switch (source)
        {
            case Money money:
                return money;
            case Sum sum:
                return sum.Reduce(to);
            default:
                throw new NotImplementedException();
        }
    }
}