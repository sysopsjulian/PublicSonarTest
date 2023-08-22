// Code: Calculator.cs

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}
// Unit Tests: CalculatorTests.cs

using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        int a = 5;
        int b = 10;

        // Act
        int result = calculator.Add(a, b);

        // Assert
        Assert.AreEqual(15, result);
    }

    [Test]
    public void Add_NegativeNumbers_ReturnsSum()
    {
        // Arrange
        int a = -8;
        int b = -5;

        // Act
        int result = calculator.Add(a, b);

        // Assert
        Assert.AreEqual(-13, result);
    }
}
