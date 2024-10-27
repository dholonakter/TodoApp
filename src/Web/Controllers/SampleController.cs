using Microsoft.AspNetCore.Mvc;

namespace Microsoft.Extensions.DependencyInjection.Controllers;


[Route("v1/test")]
public class SampleController : ControllerBase
{
 
    [HttpGet("hello")]
    public ActionResult<string> Get()
    {
        return Ok("Hello World");
    }
}