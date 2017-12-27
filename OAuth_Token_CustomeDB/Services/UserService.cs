using OAuth_Token_CustomeDB.Models;
using System.Collections.Generic;
using System.Linq;

namespace OAuth_Token_CustomeDB.Services
{
    public class UserService
    {
        public User ValidateUser(string email, string password)
        {
            // Here you can write the code to validate
            // User from database and return accordingly
            // To test we use dummy list here
            var userList = GetUserList();
            var user = userList.FirstOrDefault(x => x.Email == email && x.Password == password);
            return user;
        }

        public List<User> GetUserList()
        {
            List<User> list = new List<User>();
            list.Add(new User() { Id=101, Name= "Admin", Email= "Admin@Admin.com", Password="Admin"});
            return list;

        }
    }
}