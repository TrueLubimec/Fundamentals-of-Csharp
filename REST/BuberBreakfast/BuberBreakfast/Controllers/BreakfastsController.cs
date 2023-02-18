using BreakfastContracts;
using Microsoft.AspNetCore.Mvc;
using System;

[ApiController]
[Route("breakfasts")]
public class BreakfastsController : ControllerBase
{
    [HttpPost()]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("/breakfasts/{id:guid}")]
    public IActionResult UpsertBreakfastRequest(Guid id,UpsertBreakfastRequest request)
    {
        return Ok(id);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfastRequest(Guid id)
    {
        return Ok(id);
    }
}