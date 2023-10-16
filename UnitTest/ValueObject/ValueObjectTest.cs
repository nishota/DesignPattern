using DesignPattern.ValueObject;

namespace UnitTest.ValueObject;

public class ValueObjectTest
{
    [Fact]
    public void Add()
    {
        // Given
        var expectedValue = new Dollar(15d);
        var value = new Dollar(5d);
        var value2 = new Dollar(10d);
        // When
        var result = value.Add(value2);
    
        // Then
        result.Ammount.Is(expectedValue.Ammount);
    }
    [Fact]
    public void Times()
    {
        // Given
        var expectedValue = new Dollar(15d);
        var multiplicand = new Dollar(5d);
        var multiplier = 3d;
    
        // When
        var actualValue = multiplicand.Times(multiplier);

        // Then
        actualValue.Ammount.Is(expectedValue.Ammount);
    }

    [Fact]
    public void TimesString()
    {
        // Given
        var expectedValue = new Dollar(15d);
        var multiplicand = new Dollar(5d);
        var multiplier = "3";
    
         // When
        var actualValue = multiplicand.Times(multiplier);

        // Then
        actualValue.Ammount.Is(expectedValue.Ammount);
    }

    [Fact]
    public void TimesString_Failed()
    {
        Assert.Throws<ArgumentException>(()=>
        {
            var dollar = new Dollar("a");
        });
    }
}