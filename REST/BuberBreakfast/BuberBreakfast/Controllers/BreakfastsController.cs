using BreakfastContracts;
using Microsoft.AspNetCore.Mvc;
using System;

[ApiController]
public class BreakfastsController : ControllerBase
{
    [HttpPost("/breakfasts")]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpGet("/breakfasts/{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("/breakfasts/{id:guid}")]
    public IActionResult UpsertBreakfastRequest(Guid id,UpsertBreakfastRequest request)
    {
        return Ok(id);
    }

    [HttpDelete("/breakfasts/{id:guid}")]
    public IActionResult DeleteBreakfastRequest(Guid id)
    {
        return Ok(id);
    }
}