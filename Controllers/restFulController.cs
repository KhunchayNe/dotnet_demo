using dotnet_demo.Helpers;
using dotnet_demo.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace dotnet_demo.Controllers;

[ApiController]
[Route("api")]
public class RestFulController : ControllerBase
{
    [HttpGet("dburl")]
    public async Task<ActionResult<string>> dburl()
    {
        return casedata(0);
    }

    [HttpGet("dburl/{id:maxlength(2)}")]
    public async Task<ActionResult> Getdburl(int id)
    {
        return casedata(id);
    }

    [HttpPost("dburl")]
    public async Task<ActionResult<string>> Postdburl([FromBody] ResData value)
    {
        return casedata(value.caseId);
    }

    [HttpPut("dburl/{id:maxlength(2)}")]
    public async Task<ActionResult<string>> Putdburl(int id, [FromBody] ResData value)
    {
        return casedata(value.caseId);
    }

    [HttpPatch("dburl/{id:maxlength(2)}")]
    public async Task<ActionResult<string>> Patchdburl(int id, [FromBody] ResData value)
    {
        return casedata(value.caseId);
    }

    [HttpDelete("dburl/{id:maxlength(2)}")]
    public async Task<ActionResult<string>> Deletedburl(int id)
    {
        return casedata(id);
    }


    ActionResult casedata(int id)
    {
        switch (id)
        {
            case 0:
                return Ok();
            case 1:
                return StatusCode(StatusCodes.Status201Created);
            case 2:
                return StatusCode(203);
            case 3:
                return NoContent();
            case 4:
                return BadRequest();
            case 5:
                return Unauthorized();
            case 6:
                return StatusCode(StatusCodes.Status403Forbidden);
            case 7:
                return NotFound();
            case 8:
                return Conflict();
            case 9:
                return UnprocessableEntity();
            default:
                return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

}