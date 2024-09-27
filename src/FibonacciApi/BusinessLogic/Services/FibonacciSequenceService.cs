using FibonacciApi.BusinessLogic.Utilities;
using Microsoft.Extensions.Caching.Memory;
using System.Numerics;

namespace FibonacciApi.BusinessLogic.Services;

/// <inheritdoc cref="IFibonacciSequenceService"/>
public class FibonacciSequenceService(IMemoryCache memoryCache) : IFibonacciSequenceService
{
    /// <inheritdoc/>
    public BigInteger CalculateSequenceNumber(int sequenceIndex)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(sequenceIndex);

        if (memoryCache.TryGetValue(sequenceIndex, out int cachedResult))
        {
            return cachedResult;
        }

        BigInteger sequenceNumber = FibonacciSequenceCalculator.CalculateFibonacciNumber(sequenceIndex);

        memoryCache.Set(sequenceIndex, sequenceNumber);

        return sequenceNumber;
    }
}
