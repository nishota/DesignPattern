using DesignPattern.Strategy;

namespace UnitTest.Strategy;

public class FlyNoWayTest
{
    [Fact]
    public void Fly()
    {
        // Given
        var expectedResult = "It couldn't fly";
        var flyBehavior = new FlyNoWay();
    
        // When
        var result = flyBehavior.Fly();
    
        // Then
        result.Is(expectedResult);
    }
}