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

    /* Arrange: Vi lager en kalkulator
       Act: vi legger sammen 2 og 2
       Assert: resultatet skal være 4
    */

    [Fact]
    public void Subtract_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();

        // Act 
        var result = calculator.Sub(6,2);

        // Assert
        Assert.Equal(4, result);
    }
}
