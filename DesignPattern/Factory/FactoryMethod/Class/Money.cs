namespace DesignPattern.Factory.FactoryMethod;

public abstract class Money
{
    public double Amount { get; }
    public string Currency { get; }

    public Money(double amount, string currency)
    {
        if(currency is null or "") throw new ArgumentException("Currency is INVALID.");
        Amount = amount;
        Currency = currency;
    }

    public static Money CreateJPY(double amount)
    {
        return new JPY(amount);
    }

    public static Money CreateUSD(double amount)
    {
        return new USD(amount);
    }
}