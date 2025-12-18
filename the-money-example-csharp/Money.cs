namespace Tdd.Money;

public class Money(int amount, string currency): IEquatable<Money>
{
    protected readonly int _amount = amount;
    
    public static Money Dollar(int amount) => new Dollar(amount, "USD");
    
    public static Money Franc(int amount) => new Franc(amount, "CHF");

    public virtual Money Times(int multiplier) => null!;
    
    public string Currency => currency;
    
    public bool Equals(Money? other) =>
        other is not null &&
        _amount == other._amount &&
        Currency == other.Currency;

    public override bool Equals(object? other) =>
        other is Money money && Equals(money);

    public override string ToString() => $"{_amount} {currency}";
}