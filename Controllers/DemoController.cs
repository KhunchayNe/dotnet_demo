using Microsoft.AspNetCore.Mvc;
using dotnet_demo.Models;

namespace dotnet_demo.Controllers;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{
    // GET: /demo
    [HttpGet]
    public IActionResult Get()
    {
        // Your code here
        return Ok("Hello, World!");
    }

    // POST: /demo
    [HttpPost]
    public IActionResult Post([FromBody] YourModel model)
    {
        // Your code here
        return Ok(model);
    }

    // PUT: /demo/{id}
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] YourModel model)
    {
        // Your code here
        return Ok(model);
    }

    // DELETE: /demo/{id}
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Your code here
        return Ok($"Deleted record with ID: {id}");
    }
}


