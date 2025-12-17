namespace Tdd.Money;

public class Dollar: IEquatable<Dollar>
{
    private readonly int _amount;
    
    public Dollar(int amount)
    {
        _amount = amount;
    }

    public Dollar Times(int multiplier) =>
        new Dollar(_amount * multiplier);


    public bool Equals(Dollar? other) =>
        other is not null &&
        _amount == other._amount;

    public override bool Equals(object? other) =>
        other is Dollar dollar && Equals(dollar);

}