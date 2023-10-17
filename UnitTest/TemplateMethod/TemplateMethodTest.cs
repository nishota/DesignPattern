using DesignPattern.TemplateMethod;

namespace UnitTest.TemplateMethod;

public class TemplateMethodTest
{
    [Fact]
    public void MilkCoffee()
    {
        // Given
        var coffee = new MilkCoffee();
    
        // When
        var result = coffee.PrepareRecipe();
    
        // Then
        result.Count.Is(4);
        result[0].Is("Boil water");
        result[1].Is("Brew coffee");
        result[2].Is("Pour in cup");
        result[3].Is("Add milk");
    }

    [Fact]
    public void Tea()
    {
        // Given
        var coffee = new Tea();
    
        // When
        var result = coffee.PrepareRecipe();
    
        // Then
        result.Count.Is(4);
        result[0].Is("Boil water");
        result[1].Is("Brew Tea");
        result[2].Is("Pour in cup");
        result[3].Is("");
        result[3].IsNot("hogehoge");
    }
}