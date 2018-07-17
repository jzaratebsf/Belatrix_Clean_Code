using System;
using System.Linq;

namespace CleanCode.PoorMethodSignatures
{
    public class PoorMethodSignatures
    {
        public void ExecuteLoginUser()
        {
            var UserAuthentication = new AuthenticationClient();

            string validUser = "username";
            string validpassword = "password";
            string invalidpassword = null;
            
            var ValidLoginUser = UserAuthentication.GetAuthenticationUser(validUser, validpassword);
            var InvalidLoginUser = UserAuthentication.GetAuthenticationUser(validUser, invalidpassword);
        }
    }

    public class AuthenticationClient
    {
        private UserDatabaseClient DatabaseConexion = new UserDatabaseClient();

        public User GetAuthenticationUser(string username, string password)
        {
            return login ? LogUser(username, password) : ReturnInvalidUser(username);
        }

        private User ReturnInvalidUser(string username)
        {
            return DatabaseConexion.Users.SingleOrDefault(u => u.Username == username);
        }

        private User LogUser(string username, string password)
        {
            var user = DatabaseConexion.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
                user.LastLogin = DateTime.Now;
            return user;
        }
    }

    public class UserDatabaseClient : DbContext
    {
        public IQueryable<User> Users { get; set; }
    }

    public class DbSet<T>
    {
    }

    public class DbContext
    {
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
