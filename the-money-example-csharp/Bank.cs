namespace Tdd.Money;

public class Bank
{
    public Money Reduce(IExpression source, string to) => source.Reduce(this, to);

    public void AddRate(string from, string to, int rate)
    {
    }

    public int Rate(string from, string to) =>
        (from, to) switch
        {
            (from: "CHF", to: "USD") => 2,
            _ => 1
        };
}