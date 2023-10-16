namespace DesignPattern.Strategy;

public class MallardDuck : AbstractDuck
{
    public MallardDuck()
        : base(new FlyWithWings(), new QuackBehavior()) { }

    public override string Display()
    {
        return "This is a MallarDuck.";
    }
}