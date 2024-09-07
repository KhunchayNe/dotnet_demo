using dotnet_demo.Models;

namespace dotnet_demo.interfaces;

public interface ILogin
{
    public string Login(string username, string password);

    Task<UserDetail> GetUserDetail(int userId);

}
