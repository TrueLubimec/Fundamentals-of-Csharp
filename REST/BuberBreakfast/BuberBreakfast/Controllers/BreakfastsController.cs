using BreakfastContracts;
using Microsoft.AspNetCore.Mvc;
using System;

[ApiController]
[Route("breakfasts")]
public class BreakfastsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        var breakfast = new Breakfast(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Savory,
            request.Sweet);
        //TODO: save breakfast to database

        var response = new BreakfastResponse(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            breakfast.LastModifiedDateTime,
            breakfast.Savory,
            breakfast.Sweet);
        
        return CreatedAtAction(
            actionName: nameof(GetBreakfast),
            routeValues: new { id = breakfast.Id },
            value: response);
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