namespace Tdd.Money;

public class Franc: Money, IEquatable<Franc>
{
    public Franc(int amount) :  base(amount)
    {
    }

    public Franc Times(int multiplier) =>
        new Franc(_amount * multiplier);


    public bool Equals(Franc? other) =>
        other is not null &&
        _amount == other._amount;

    public override bool Equals(object? other) =>
        other is Franc franc && Equals(franc);

}