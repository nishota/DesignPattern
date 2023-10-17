using DesignPattern.Decorator;

namespace UnitTest.Decorator;

public class DecoratorTest
{
    [Fact]
    public void Espresso()
    {
        // Given
        Coffee espresso = CoffeeMaker.MakeEspresso();

        // When
        var cost = espresso.Cost();
        var descriptions = espresso.GetDescriptions();

        // Then
        cost.Is(300);
        descriptions.Count.Is(1);
        descriptions[0].Is(nameof(Espresso));
    }

    [Fact]
    public void EspressoWithMocha()
    {
        // Given
        Coffee espresso = CoffeeMaker.MakeEspresso();
        espresso = ToppingMaker.MakeMocha(espresso);

        // When
        var cost = espresso.Cost();
        cost = espresso.Cost();
        var descriptions = espresso.GetDescriptions();
        descriptions = espresso.GetDescriptions();

        // Then
        cost.Is(350);
        descriptions.Count.Is(2);
        descriptions[0].Is(nameof(Espresso));
        descriptions[1].Is(nameof(Mocha));
    }

    [Fact]
    public void EspressoWithMilkWithMocha()
    {
        // Given
        Coffee espresso = CoffeeMaker.MakeEspresso();
        espresso = ToppingMaker.MakeMilk(espresso);
        espresso = ToppingMaker.MakeMocha(espresso);

        // When
        var cost = espresso.Cost();
        var descriptions = espresso.GetDescriptions();

        // Then
        cost.Is(420);
        descriptions.Count.Is(3);
        descriptions[0].Is(nameof(Espresso));
        descriptions[1].Is(nameof(Milk));
        descriptions[2].Is(nameof(Mocha));
    }

    [Fact]
    public void HouseBlend()
    {
        // Given
        Coffee blend = CoffeeMaker.MakeBlend();

        // When
        var cost = blend.Cost();
        var descriptions = blend.GetDescriptions();

        // Then
        cost.Is(250);
        descriptions.Count.Is(1);
        descriptions[0].Is(nameof(HouseBlend));
    }

    [Fact]
    public void HouseBlendWithMilk()
    {
        // Given
        Coffee blend = CoffeeMaker.MakeBlend();
        blend = ToppingMaker.MakeMilk(blend);

        // When
        var cost = blend.Cost();
        var descriptions = blend.GetDescriptions();

        // Then
        cost.Is(320);
        descriptions.Count.Is(2);
        descriptions[0].Is(nameof(HouseBlend));
        descriptions[1].Is(nameof(Milk));
    }
}