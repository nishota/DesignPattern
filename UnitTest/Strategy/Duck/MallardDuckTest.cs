using DesignPattern.Strategy;

namespace UnitTest.Strategy;

public class MallardDuckTest
{
    [Fact]
    public void Display()
    {
        // Given
        var expectedResult = "This is a MallarDuck.";
        var duck = new MallardDuck();
    
        // When
        var result = duck.Display();
    
        // Then
        result.Is(expectedResult);
    }

    [Fact]
    public void Fly()
    {
        // Given
        var expectedResult = "It fly with the wings.";
        var duck = new MallardDuck();
    
        // When
        var result = duck.Fly();
    
        // Then
        result.Is(expectedResult);
    }

    [Fact]
    public void Quack()
    {
        // Given
        var expectedResult = "Quack!";
        var duck = new MallardDuck();
    
        // When
        var result = duck.Quack();
    
        // Then
        result.Is(expectedResult);
    }
}