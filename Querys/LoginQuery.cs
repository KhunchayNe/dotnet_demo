using dotnet_demo.interfaces;
using dotnet_demo.Models;

namespace dotnet_demo.Querys;


public class LoginQuery : ILogin
{
    public string Login(string username, string password)
    {
        return "Login Success";
    }

    public async Task<UserDetail> GetUserDetail(int userId)
    {
        return new UserDetail
        {
            Username = "admin",
            Email = "admin@gmail.com",
        };
    }
}