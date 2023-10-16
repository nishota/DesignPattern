namespace DesignPattern.Strategy;

public class FlyNoWay : IFlyBehavior
{
    public string Fly()
    {
        return "It couldn't fly";
    }
}
