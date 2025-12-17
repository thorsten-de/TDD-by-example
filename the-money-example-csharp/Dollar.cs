using System.Diagnostics;

namespace Tdd.Money;

public class Dollar: IEquatable<Dollar>
{
    public int Amount { get; private set; }
    
    public Dollar(int amount)
    {
        Amount = amount;
    }

    public Dollar Times(int multiplier) =>
        new Dollar(Amount * multiplier);


    public bool Equals(Dollar? other) =>
        other is not null &&
        Amount == other.Amount;

    public override bool Equals(object? other) =>
        other is Dollar dollar && Equals(dollar);

}