using System.ComponentModel.DataAnnotations;
using dotnet_demo.interfaces;
using dotnet_demo.Models;
using Microsoft.AspNetCore.Mvc;
namespace dotnet_demo.Controllers;

[ApiController]
[Route("api")]
public class LoginController : ControllerBase{
    private readonly ILogin _login;

    public LoginController(ILogin login)
    {
        this._login = login;
    }
 // GET: /demo
    [HttpGet("User/{userId}")]
    public async Task<ActionResult<UserDetail>> User(int userId)
    {
        var res = await this._login.GetUserDetail(userId);
        return StatusCode(StatusCodes.Status200OK, res);
    }

    [HttpPost("Register")]
    public IActionResult Register([Required, FromBody] UserDetail body)
    {
        return StatusCode(StatusCodes.Status200OK, body);
    }

    
}