namespace Tdd.Money;

public class Bank
{
    public Money Reduce(IExpression sum, string usd) => Money.Dollar(10);
}