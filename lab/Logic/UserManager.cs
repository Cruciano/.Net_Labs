using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab.Logic.Exceptions;

namespace lab.Logic
{
    class UserManager
    {
        private static List<User> _users = new();
        private static User _currentUser = new();
        private static int _lastId;

        public delegate void UserEventHandler(string message);
        public event UserEventHandler Notify;

        public int CreateUser(string name, string surname, string password)
        {
            if ((name is null or "") || (surname is null or "") || (password is null or ""))
            {
                throw new RegistrationException("Invalid input");
            }

            User usr = new(_lastId++, name, surname, password);
            _users.Add(usr);

            Notify?.Invoke("Користувач створений");
            return usr.Id;
        }

        public bool AuthorizeUser(int id, string pass)
        {
            if (!_users.Exists(u => u.Id == id) || !_users.First(u => u.Id == id).CheckPass(pass))
            {
                throw new AuthorizeException("Invalid login or password");
            }

            _currentUser = _users.First(u => u.Id == id);

            Notify?.Invoke("Користувача авторизовано");
            return true;
        }

        public User GetAuthorizedUser()
        {
            return _currentUser;
        }
    }
}