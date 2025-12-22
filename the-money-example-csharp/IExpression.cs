namespace Tdd.Money;

public interface IExpression
{
    Money Reduce(string to);
}