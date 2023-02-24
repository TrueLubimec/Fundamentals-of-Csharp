using BreakfastContracts;
using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using System;
using ServiceError;

[ApiController]
[Route("breakfasts")]
public class BreakfastsController : ControllerBase
{
    private readonly IBreakfastService _breakfastService;

    public BreakfastsController(IBreakfastService breakfastService)
    {

        _breakfastService = breakfastService;
    }

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

        _breakfastService.CreateBreakfast(breakfast);

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
        ErrorOr<Breakfast> getBreakfastResult = _breakfastService.GetBreakfast(id);
        if (getBreakfastResult.IsError &&
            getBreakfastResult.FirstError == Errors.Breakfast.NotFound)
        {
            return NotFound();
        }
        var breakfast = getBreakfastResult.Value;
        
        var response = new BreakfastResponse(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            breakfast.LastModifiedDateTime,
            breakfast.Savory,
            breakfast.Sweet);
        return Ok(response);
    }

    [HttpPut("/breakfasts/{id:guid}")]
    public IActionResult UpsertBreakfastRequest(Guid id,UpsertBreakfastRequest request)
    {
        var breakfast = new Breakfast(
            id,
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Savory,
            request.Sweet);
        _breakfastService.UpsertBreakfast(breakfast);

        // TODO: return 201 if a new breakfast was created
        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfastRequest(Guid id)
    {
        _breakfastService.DeleteBreakfast(id);
        return NoContent();
    }
}