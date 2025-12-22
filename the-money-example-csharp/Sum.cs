namespace Tdd.Money;

public class Sum: IExpression
{
    public IExpression augend;
    public IExpression addend;

    public Sum(IExpression augend, IExpression addend)
    {
        this.augend = augend;
        this.addend = addend;
    }

    public Money Reduce(Bank bank, string to) => 
        new(augend.Reduce(bank, to).Amount + addend.Reduce(bank, to).Amount, to);
}