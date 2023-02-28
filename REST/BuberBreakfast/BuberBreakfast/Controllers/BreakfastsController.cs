using BreakfastContracts;
using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using System;
using ServiceError;

namespace BuberBreakfast.Controllers;


public class BreakfastsController : ApiController
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

        ErrorOr<Created> createBreakfastResult = _breakfastService.CreateBreakfast(breakfast);

        if (createBreakfastResult.IsError)
        {
            return Problem(createBreakfastResult.Errors);
        }
        
        return CreatedAtAction(
            actionName: nameof(GetBreakfast),
            routeValues: new { id = breakfast.Id },
            value: MapBreakfastRespond(breakfast));
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        ErrorOr<Breakfast> getBreakfastResult = _breakfastService.GetBreakfast(id);

        return getBreakfastResult.Match(
            breakfast => Ok(MapBreakfastRespond(breakfast)),
            errors => Problem(errors: errors));
        // if (getBreakfastResult.IsError &&
        //     getBreakfastResult.FirstError == Errors.Breakfast.NotFound)
        // {
        //     return NotFound();
        // }

        // var breakfast = getBreakfastResult.Value;

        // BreakfastResponse response = MapBreakfastRespond(breakfast);
        // return Ok(response);
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
        ErrorOr<Deleted> deleteResult = _breakfastService.DeleteBreakfast(id);

        return deleteResult.Match(
            deleted => NoContent(),
            error => Problem(error));
    }


        private static BreakfastResponse MapBreakfastRespond(Breakfast breakfast)
    {
        return new BreakfastResponse(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            breakfast.LastModifiedDateTime,
            breakfast.Savory,
            breakfast.Sweet);
    }

}