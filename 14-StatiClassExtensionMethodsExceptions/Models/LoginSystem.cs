using _14_StatiClassExtensionMethodsExceptions.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _14_StatiClassExtensionMethodsExceptions.Models
{
    public class LoginSystem
    {

        private User[] users;
        private const int MaxAttempts = 3;

        public LoginSystem()
        {
            users = new User[]
            {
                new User("admin", "admin123"),
                new User("student", "student123"),
                new User("teacher", "teacher123")
            };
        }
        public void ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username) && username.Length < 3)
                throw new InvalidUsernameException();
        }
        public void ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) && password.Length < 6)
                throw new InvalidPasswordException();
        }
        private User FindUser(string username)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Username.ToLower() == username.ToLower())
                {
                    return users[i];
                }
            }
            return null;

        }
        public bool Login(string username, string password)
        {
            ValidatePassword(password);
            ValidateUsername(username);
            User user = FindUser(username);
            if (user == null)
                throw new UserNotFoundException(username);

            if (user.IsLocked)
                throw new AccountLockedException();

            if (user.Password == password)
            {
                user.FailedAttempts = 0;
                Console.WriteLine($"Login successful! Welcome, {user.Username}!");
                return true;
            }
            else
            {
                user.FailedAttempts++;
                int attemptsLeft = MaxAttempts - user.FailedAttempts;

                if (attemptsLeft > 0)
                    throw new IncorrectPasswordException(attemptsLeft);
                else
                {
                    user.IsLocked = true;
                    throw new AccountLockedException();
                }
            }
        }

        internal void ShowUsers()
        {
            
        }
    }
}
