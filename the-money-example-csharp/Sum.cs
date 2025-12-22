namespace Tdd.Money;

public class Sum: IExpression
{
    public Money augend;
    public Money addend;

    public Sum(Money augend, Money addend)
    {
        this.augend = augend;
        this.addend = addend;
    }

    public Money Reduce(string to) => new(augend.Amount + addend.Amount, to);
}