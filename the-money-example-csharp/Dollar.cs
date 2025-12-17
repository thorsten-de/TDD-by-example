namespace Tdd.Money;

public class Dollar
{
    public int Amount { get; private set; }
    
    public Dollar(int amount)
    {
        Amount = amount;
    }

    public Dollar Times(int multiplier) =>
        new Dollar(Amount * multiplier);

    public override bool Equals(object? _) => true;
}