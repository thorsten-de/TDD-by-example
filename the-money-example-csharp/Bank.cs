namespace Tdd.Money;

public class Bank
{
    private Dictionary<(string, string), int> _rates = new();
    public Money Reduce(IExpression source, string to) => source.Reduce(this, to);

    public void AddRate(string from, string to, int rate)
    {
        _rates.Add((from, to), rate);
    }

    public int Rate(string from, string to) => 
        _rates.GetValueOrDefault((from, to));
}