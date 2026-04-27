using Xunit;
using Calculator;

namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange: Sett opp testdata og objekter
        var calculator = new Calculator();

        // Act: Utfør handlingen du tester
        var result = calculator.Add(2, 2);

        // Assert: Sjekk at resultatet er riktig
        Assert.Equal(4, result);

    }
}
