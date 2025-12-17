namespace Tdd.Money;

public class MoneyTest
{
    [Fact]
    public void TestMultiplication()
    {
        Dollar five = new Dollar(5);
        Dollar product = five.Times(2);
        Assert.Equal(10, product.Amount);
        
        product = five.Times(3);
        Assert.Equal(15, product.Amount);
    }
    
    [Fact]
    public void TestEquality()
    {
        Assert.Equal(new Dollar(5), new Dollar(5));
        Assert.NotEqual(new Dollar(5), new Dollar(6));
    }
}