using Microsoft.AspNetCore.Mvc;
using WebAPI.Services.Classes;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers;
[ApiController]
[Route("api/v1/[controller]")]

public class TestController : ControllerBase
{
    private readonly ITestService testService;

    public TestController(ITestService itestService)
    {
        this.testService = itestService;
    }

    [HttpPost]
  public async Task<IActionResult> test([FromBody] string test )
    {
        var res = await testService.test(test);
        return Ok(res);
    }

}
