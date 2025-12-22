namespace Tdd.Money;

public class Money(int amount, string currency): IExpression, IEquatable<Money>
{
    protected readonly int _amount = amount;
    
    public static Money Dollar(int amount) => new Money(amount, "USD");
    
    public static Money Franc(int amount) => new Money(amount, "CHF");

    public Money Times(int multiplier) =>
        new Money(_amount * multiplier, Currency);
    
    public string Currency => currency;
    
    public bool Equals(Money? other) =>
        other is not null &&
        _amount == other._amount &&
        Currency == other.Currency;

    public override bool Equals(object? other) =>
        other is Money money && Equals(money);

    public override string ToString() => $"{_amount} {currency}";

    public IExpression Plus(Money addend) => 
        new Sum(this, addend);
}