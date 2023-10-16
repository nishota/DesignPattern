using DesignPattern.Strategy;

namespace UnitTest.Strategy;

public class SqueakTest
{
    [Fact]
    public void Quack()
    {
        // Given
        var expectedResult = "Squeak!";
        var quackBehavior = new SqueakBehavior();
    
        // When
        var result = quackBehavior.Quack();
    
        // Then
        result.Is(expectedResult);
    }
}