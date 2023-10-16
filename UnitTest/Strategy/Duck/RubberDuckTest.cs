using DesignPattern.Strategy;

namespace UnitTest.Strategy;

public class RubberDuckTest
{
    [Fact]
    public void Display()
    {
        // Given
        var expectedResult = "This is a RubberDuck.";
        var duck = new RubberDuck();
    
        // When
        var result = duck.Display();
    
        // Then
        result.Is(expectedResult);
    }

    [Fact]
    public void Fly()
    {
        // Given
        var expectedResult = "It couldn't fly";
        var duck = new RubberDuck();
    
        // When
        var result = duck.Fly();
    
        // Then
        result.Is(expectedResult);
    }

    [Fact]
    public void Quack()
    {
        // Given
        var expectedResult = "Squeak!";
        var duck = new RubberDuck();
    
        // When
        var result = duck.Quack();
    
        // Then
        result.Is(expectedResult);
    }
}