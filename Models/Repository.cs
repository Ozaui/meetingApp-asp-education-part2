using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meetingApp_asp_education_part2.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();
        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, name = "Ozay", phone = "123", email = "ozay@gmail.com", willAttend = true });
            _users.Add(new UserInfo() { Id = 2, name = "Merve", phone = "456", email = "merve@gmail.com", willAttend = true });
            _users.Add(new UserInfo() { Id = 3, name = "Ayse", phone = "789", email = "ayse@gmail.com", willAttend = false });
        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}