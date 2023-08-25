namespace BLLayer
{

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository = new UserRepository();
        private static User _currentUser;

        public bool RegisterUser(string username, string password)
        {
            User existingUser = _userRepository.GetUserByUsername(username);
            if (existingUser != null)
                return false;

            User newUser = new User(username, password);
            _userRepository.AddUser(newUser);

            return true;
        }

        public bool LoginUser(string username, string password)
        {
            User user = _userRepository.GetUserByUsername(username);
            if (user == null || user.Password != password)
                return false;

            _currentUser = user;
            return true;
        }

        public bool LogoutUser()
        {
            if (_currentUser == null)
                return false;

            _currentUser = null;
            return true;
        }
    }

}