namespace DesignPattern.TemplateMethod;

public class MilkCoffee : CaffeineBeverage
{
    protected override string AddCondiments()
    {
        return "Add milk";
    }

    protected override string Brew()
    {
        return "Brew coffee";
    }
}