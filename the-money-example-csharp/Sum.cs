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

    public Money Reduce(Bank bank, string to) => 
        new(augend.Reduce(bank, to).Amount + addend.Reduce(bank, to).Amount, to);
}