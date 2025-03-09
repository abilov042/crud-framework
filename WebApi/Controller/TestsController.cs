using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller;

[Route("/v1/tests")]
[ApiController]
public class TestsController : ControllerBase
{
    [HttpGet]
    public string test()
    {
        return "Hello, World";
    }
}