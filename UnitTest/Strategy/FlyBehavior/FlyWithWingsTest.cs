using DesignPattern.Strategy;

namespace UnitTest.Strategy;

public class FlyWithWingsTest
{
    [Fact]
    public void Fly()
    {
        // Given
        var expectedResult = "It fly with the wings.";
        var flyBehavior = new FlyWithWings();
    
        // When
        var result = flyBehavior.Fly();
    
        // Then
        result.Is(expectedResult);
    }
}