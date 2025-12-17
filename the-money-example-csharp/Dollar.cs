namespace Tdd.Money;

public class Dollar: Money, IEquatable<Dollar>
{
    public Dollar(int amount) :  base(amount)
    {
    }

    public Dollar Times(int multiplier) =>
        new Dollar(_amount * multiplier);


    public bool Equals(Dollar? other) =>
        other is not null &&
        _amount == other._amount;

    public override bool Equals(object? other) =>
        other is Dollar dollar && Equals(dollar);

}