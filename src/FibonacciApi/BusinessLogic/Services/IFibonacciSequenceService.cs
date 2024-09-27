using System.Numerics;

namespace FibonacciApi.BusinessLogic.Services;

/// <summary>
/// Defines a service for calculating Fibonacci numbers based on a given sequence index.
/// </summary>
public interface IFibonacciSequenceService
{
    /// <summary>
    /// Calculates the Fibonacci number for the given sequence index.
    /// </summary>
    public BigInteger CalculateSequenceNumber(int sequenceNumber);
}
