using Microsoft.AspNetCore.Mvc;

namespace BookHouse.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DemoController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
        => Ok(new { Message = "Hello from BookHouse API" });
}