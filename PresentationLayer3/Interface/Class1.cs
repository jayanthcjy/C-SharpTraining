namespace Interface
{
    public interface IUserService
    {
        bool RegisterUser(string username, string password);
        bool LoginUser(string username, string password);
    }

    public interface IUserRepository
    {
        void AddUser(User user);
        User GetUserByUsername(string username);
    }

}