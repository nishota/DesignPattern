
namespace DesignPattern.TemplateMethod;

public abstract class CaffeineBeverage
{
    /// <summary>
    /// カフェイン飲料作成手順を生成する
    /// </summary>
    /// <returns></returns>
    public List<string> PrepareRecipe()
    {
        var result = new List<string>
        {
            BoilWater(),
            Brew(),
            PourInCup(),
            CustomerWantsCondiments() ? AddCondiments() : ""
        };
        return result;
    }


    private string PourInCup()
    {
        return "Pour in cup";
    }

    private string BoilWater()
    {
        return "Boil water";
    }

    protected virtual bool CustomerWantsCondiments()
    {
        return true;
    }

    protected abstract string AddCondiments();
    protected abstract string Brew();
}