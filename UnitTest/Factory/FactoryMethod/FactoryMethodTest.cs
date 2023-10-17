using DesignPattern.Factory.FactoryMethod;
using Xunit.Sdk;

namespace UnitTest.Factory.FactoryMethod;

public class FactoryMethodTest
{
    class DummyMoney : Money
    {
        public DummyMoney(string currency) : base(1, currency) { }
    }

    [Fact]
    public void CreateJPY()
    {
        var jpy = Money.CreateJPY(100);

        jpy.Amount.Is(100);
        jpy.Currency.Is("JPY");
    }

    [Fact]
    public void CreateUSD()
    {
        var usd = Money.CreateUSD(1);

        usd.Amount.Is(1);
        usd.Currency.Is("USD");
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void WhenCurrencyIsInvalid(string currency)
    {
        var ex = Assert.Throws<ArgumentException>(()=>{
            var dummyMoney = new DummyMoney(currency);
        });
        ex.IsNotNull();
        ex.Message.Is("Currency is INVALID.");
    }
}