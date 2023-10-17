namespace DesignPattern.TemplateMethod;

public class Tea : CaffeineBeverage
{
    protected override bool CustomerWantsCondiments()
    {
        return false;
    }
    protected override string AddCondiments()
    {
        return "hogehoge";
    }

    protected override string Brew()
    {
        return "Brew Tea";
    }
}