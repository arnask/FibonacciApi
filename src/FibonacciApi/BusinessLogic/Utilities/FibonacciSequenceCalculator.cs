using System.Numerics;

namespace FibonacciApi.BusinessLogic.Utilities;

/// <summary>
/// Utility class for calculating Fibonacci number.
/// </summary>
public static class FibonacciSequenceCalculator
{
    /// <summary>
    /// Calculates Fibonacci sequence number.
    /// </summary>
    public static BigInteger CalculateFibonacciNumber(int sequenceIndex) 
    {
        if (sequenceIndex < 0 || sequenceIndex > 1000)
        {
            throw new ArgumentOutOfRangeException(nameof(sequenceIndex), "The argument must be in the range of 0 to 1000");
        }  

        BigInteger previousNumber = 0, currentNumber = 1;

        for (int i = 2; i <= sequenceIndex; i++)
        {
            BigInteger nextNumber = previousNumber + currentNumber;
            previousNumber = currentNumber;
            currentNumber = nextNumber;
        }

        return sequenceIndex == 0 ? previousNumber : currentNumber;
    }
}
