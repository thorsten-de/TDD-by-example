namespace Tdd.Money;

public class MoneyTest
{
    [Fact]
    public void TestMultiplication()
    {
        Money five = Money.Dollar(5);
        Assert.Equal(Money.Dollar(10), five.Times(2));
        Assert.Equal(Money.Dollar(15), five.Times(3));
    }

    [Fact]
    public void TestFrancMultiplication()
    {
        Money five = Money.Franc(5);
        Assert.Equal(Money.Franc(10), five.Times(2));
        Assert.Equal(Money.Franc(15), five.Times(3));
    }

    [Fact]
    public void TestEquality()
    {
        Assert.Equal(Money.Dollar(5), Money.Dollar(5));
        Assert.NotEqual(Money.Dollar(5), Money.Dollar(6));
        Assert.NotEqual(Money.Franc(5), Money.Dollar(5));
    }

    [Fact]
    public void TestCurrency()
    {
        Assert.Equal("USD", Money.Dollar(1).Currency);
        Assert.Equal("CHF", Money.Franc(1).Currency);
    }
    
    [Fact]
    public void TestSimpleAddition()
    {
        Money five = Money.Dollar(5);
        IExpression sum = five.Plus(five);
        Bank bank = new Bank();
        Money reducedSum = bank.Reduce(sum, "USD");
        Assert.Equal(Money.Dollar(10), reducedSum);
    }

    [Fact]
    public void TestPlusReturnsSum()
    {
        Money five = Money.Dollar(5);
        IExpression result = five.Plus(five);
        
        Sum sum = (Sum)result;
        Assert.Equal(five, sum.augend);
        Assert.Equal(five, sum.addend);
    }

    [Fact]
    public void TestReduceSum()
    {
        IExpression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
        Bank bank = new Bank();
        Money result = bank.Reduce(sum, "USD");
        Assert.Equal(Money.Dollar(7), result);
    }

    [Fact]
    public void TestReduceMoney()
    {
        Bank bank = new Bank();
        Money result = bank.Reduce(Money.Dollar(1), "USD");
        Assert.Equal(Money.Dollar(1), result);
    }
}