namespace DesignPattern.Factory.FactoryMethod;

public class JPY : Money
{
    public JPY(double amount): base(amount, nameof(JPY)){ }
}