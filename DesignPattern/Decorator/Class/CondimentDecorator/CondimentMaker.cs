namespace DesignPattern.Decorator;

public static class ToppingMaker
{
    public static CondimentDecorator MakeMocha(Coffee coffee)
    {
        return new Mocha(coffee);
    }
    public static CondimentDecorator MakeMilk(Coffee coffee)
    {
        return new Milk(coffee);
    }
}