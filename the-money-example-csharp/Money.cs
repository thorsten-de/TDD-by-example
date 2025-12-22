namespace Tdd.Money;

public class Money(int amount, string currency): IExpression, IEquatable<Money>
{
    public int Amount { get; } = amount;
    
    public static Money Dollar(int amount) => new Money(amount, "USD");
    
    public static Money Franc(int amount) => new Money(amount, "CHF");

    public IExpression Times(int multiplier) =>
        new Money(Amount * multiplier, Currency);
    
    public string Currency => currency;
    
    public bool Equals(Money? other) =>
        other is not null &&
        Amount == other.Amount &&
        Currency == other.Currency;

    public override bool Equals(object? other) =>
        other is Money money && Equals(money);

    public override string ToString() => $"{Amount} {currency}";

    public IExpression Plus(IExpression addend) => 
        new Sum(this, addend);

    public Money Reduce(Bank bank, string to)
    {
        int rate = bank.Rate(Currency, to);
        return new Money(Amount / rate, to);
    }

}