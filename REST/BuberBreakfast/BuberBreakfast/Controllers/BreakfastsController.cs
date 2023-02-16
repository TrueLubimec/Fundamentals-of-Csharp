using Microsoft.AspNetCore.Mvc;
using System;
namespace Buberbreakfast;

[ApiController]
public class BreakfastsController : ControllerBase
{
    [HttpPost("/breakfasts")]
    public IActionResult CreateBreakfast(CreateBreaksatRequest request)
    {

    }
}