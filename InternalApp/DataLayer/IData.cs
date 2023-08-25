
using BusinessModels;

namespace DataLayer
{
    /// <summary>
    /// interface to access the methods inside the DALAuthentication
    /// </summary>
    public interface IData
    {
        bool IsLogin(Users user);
        bool IsRegister(Users user);
    }
}
