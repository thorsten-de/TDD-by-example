namespace Tdd.Money;

public class Franc: Money, IEquatable<Franc>
{
    private readonly int _amount;
    
    public Franc(int amount) :  base(amount)
    {
        _amount = amount;
    }

    public Franc Times(int multiplier) =>
        new Franc(_amount * multiplier);


    public bool Equals(Franc? other) =>
        other is not null &&
        _amount == other._amount;

    public override bool Equals(object? other) =>
        other is Franc franc && Equals(franc);

}