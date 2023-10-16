using DesignPattern.Strategy;

namespace UnitTest.Strategy;

public class QuackTest
{
    [Fact]
    public void Quack()
    {
        // Given
        var expectedResult = "Quack!";
        var quackBehavior = new QuackBehavior();
    
        // When
        var result = quackBehavior.Quack();
    
        // Then
        result.Is(expectedResult);
    }
}