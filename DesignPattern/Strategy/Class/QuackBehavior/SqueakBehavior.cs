namespace DesignPattern.Strategy;

public class SqueakBehavior : IQuackBehavior
{
    public string Quack()
    {
        return "Squeak!";
    }
}
