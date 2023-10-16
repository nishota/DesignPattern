namespace DesignPattern.Strategy;

public class QuackBehavior : IQuackBehavior
{
    public string Quack()
    {
        return "Quack!";
    }
}
