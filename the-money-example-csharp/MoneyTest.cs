namespace Tdd.Money;

public class MoneyTest
{
    [Fact]
    public void TestMultiplication()
    {
        Dollar five = new Dollar(5);
        Assert.Equal(new Dollar(10), five.Times(2));
        Assert.Equal(new Dollar(15), five.Times(3));
    }

    [Fact]
    public void TestFrancMultiplication()
    {
        Franc five = new Franc(5);
        Assert.Equal(new Franc(10), five.Times(2));
        Assert.Equal(new Franc(15), five.Times(3));
    }

    [Fact]
    public void TestEquality()
    {
        Assert.Equal(new Dollar(5), new Dollar(5));
        Assert.NotEqual(new Dollar(5), new Dollar(6));
    }
}