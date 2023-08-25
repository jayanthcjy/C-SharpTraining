namespace DALayer
{
    // Data Layer
   

    public class UserRepository : IUserRepository
    {
        private readonly List<User> _userList = new List<User>();

        public void AddUser(User user)
        {
            _userList.Add(user);
        }

        public User GetUserByUsername(string username)
        {
            return _userList.Find(user => user.Username == username);
        }
    }

    // Domain Model
    public class User
    {
        public string Username { get; }
        public string Password { get; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

}