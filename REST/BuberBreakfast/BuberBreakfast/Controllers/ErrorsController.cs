using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

public class ErorrsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}