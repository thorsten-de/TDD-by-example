namespace Tdd.Money;

public class MoneyTest
{
    [Fact]
    public void TestMultiplicaton()
    {
        Dollar five = new Dollar(5);
        five.Times(2);
        Assert.Equal(10, five.Amount);
    }
}