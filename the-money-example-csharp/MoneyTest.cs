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
}