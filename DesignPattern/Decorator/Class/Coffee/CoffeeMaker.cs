namespace DesignPattern.Decorator;

public static class CoffeeMaker
{
    public static Coffee MakeEspresso()
    {
        return new Espresso();
    }
    public static Coffee MakeBlend()
    {
        return new HouseBlend();
    }
}