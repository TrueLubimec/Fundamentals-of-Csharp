using Microsoft.AspNetCore.Mvc;

public class ErorrsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}