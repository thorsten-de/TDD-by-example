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

    public IExpression Plus(IExpression addend) => new Sum(this, addend);

    public IExpression Times(int multiplier) => 
        new Sum(augend.Times(multiplier), addend.Times(multiplier));
}