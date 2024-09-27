using FibonacciApi.BusinessLogic.Utilities;

namespace FibonacciApi.Tests;

public class FibonacciSequenceCalculatorTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(5, 5)]
    [InlineData(6, 8)]
    [InlineData(7, 13)]
    [InlineData(8, 21)]
    [InlineData(9, 34)]
    [InlineData(10, 55)]
    public void CalculateFibonacciNumber_ShouldReturnCorrectValue(int sequenceIndex, int expectedNumber)
    {
        var sequenceNumber = FibonacciSequenceCalculator.CalculateFibonacciNumber(sequenceIndex);
        Assert.Equal(expectedNumber, sequenceNumber);
    }

    [Fact]
    public void CalculateFibonacciNumber_WhenNumberIsNegative_ShouldThrowException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => FibonacciSequenceCalculator.CalculateFibonacciNumber(-1));
    }
}