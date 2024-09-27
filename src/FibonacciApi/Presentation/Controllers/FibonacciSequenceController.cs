using FibonacciApi.BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace FibonacciApi.Presentation.Controllers;

/// <summary>
/// Fibonacci sequence controller.
/// </summary>
[Route("api")]
[ApiController]
public class FibonacciSequenceController(IFibonacciSequenceService sequenceFinderService, ILogger<FibonacciSequenceController> logger) : ControllerBase
{
    /// <summary>
    /// Calculates the Fibonacci number for the given index and returns it.
    /// </summary>
    /// <param name="index">The index of the Fibonacci sequence to calculate (must be between 0 and 1000).</param>
    [HttpGet("CalculateFibonacciNumber/{index}")]
    public IActionResult CalculateFibonacciNumber(int index)
    {
        if (index < 0 || index > 1000)
        {
            logger.LogWarning("Invalid index {index} received. Must be between 0 and 1000.", index);
            return BadRequest("Index must be between 0 and 1000.");
        }

        try
        {
            BigInteger fibonachiIndex = sequenceFinderService.CalculateSequenceNumber(index);

            return Ok(fibonachiIndex.ToString());
        }
        catch (ArgumentOutOfRangeException ex)
        {
            logger.LogError(ex, "Index {index} was out of range", index);
            return BadRequest("Index must be between 0 and 1000.");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while processing the request.");
            return StatusCode(500, "Internal server error occurred while processing your request");
        }
    }
}
