namespace DesignPattern.Strategy;

public class RubberDuck : AbstractDuck
{
    public RubberDuck()
        : base(new FlyNoWay(), new SqueakBehavior()) { }

    public override string Display()
    {
        return "This is a RubberDuck.";
    }
}