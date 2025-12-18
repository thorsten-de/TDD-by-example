namespace Tdd.Money;

public abstract class Money(int amount): IEquatable<Money>
{
    protected readonly int _amount = amount;
    
    public static Money Dollar(int amount) => new Dollar(amount);
    
    public static Money Franc(int amount) => new Franc(amount);
    
    public abstract Money Times(int multiplier);
    
    public abstract string Currency { get; }
    
    public bool Equals(Money? other) =>
        other is not null &&
        _amount == other._amount &&
        GetType() == other.GetType();

    public override bool Equals(object? other) =>
        other is Money money && Equals(money);
}