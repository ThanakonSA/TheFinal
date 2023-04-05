using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinal
{
    internal class Login1v
    {
        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public User(string username, string password)
            {
                Username = username;
                Password = password;
            }
        }
        public class Authentication
        {
            public List<User> users;

            public Authentication()
            {

                users = new List<User>();


                users.Add(new User("text", "1223"));
                users.Add(new User("text1", "1224"));
                users.Add(new User("text2", "1225"));
            }
            public bool Login(string username, string password)
            {

                var user = users.FirstOrDefault(u => u.Username == username);


                if (user == null)
                {
                    return false;
                }


                if (user.Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
