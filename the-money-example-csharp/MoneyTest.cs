namespace Tdd.Money;

public class MoneyTest
{
    [Fact]
    public void TestMultiplication()
    {
        Dollar five = new Dollar(5);
        Dollar product = five.Times(2);
        Assert.Equal(new Dollar(10), product);
        
        product = five.Times(3);
        Assert.Equal(new Dollar(15), product);
    }
    
    [Fact]
    public void TestEquality()
    {
        Assert.Equal(new Dollar(5), new Dollar(5));
        Assert.NotEqual(new Dollar(5), new Dollar(6));
    }
}