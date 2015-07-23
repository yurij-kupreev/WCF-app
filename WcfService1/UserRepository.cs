using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        User AddNewUser(User item);
        bool DeleteAUser(int id);
        bool UpdateAUser(User item);
    }

    public class UserRepository : IUserRepository
    {
        private List<User> Users = new List<User>();
        private int counter = 1;

        public UserRepository()
        {
            AddNewUser(new User { Name = "Christa Becker", Phone = "+1 (968) 417-2451" });
            AddNewUser(new User { Name = "Sawyer Guthrie", Phone = "+1 (946) 514-2633" });
            AddNewUser(new User { Name = "Snider Patterson", Phone = "+1 (916) 490-3989" });
            AddNewUser(new User { Name = "Mcconnell Gill", Phone = "+1 (889) 495-3063" });
            AddNewUser(new User { Name = "Estella Carroll", Phone = "+1 (961) 580-3847" });
            AddNewUser(new User { Name = "Darla Mullins", Phone = "+1 (901) 510-3012" });
            AddNewUser(new User { Name = "Beck Riggs", Phone = "+1 (888) 574-3516" });
        }

        public User AddNewUser(User newUser)
        {
            if (newUser == null)
                throw new ArgumentNullException("newUser");
            newUser.Id = counter++;
            Users.Add(newUser);
            return newUser;
        }
        public List<User> GetAllUsers()
        {
            return Users.OrderBy(p => p.Id).Select(p => p).ToList();
        }   
        public User GetUserById(int UserId)
        {
            return Users.Find(b => b.Id == UserId);
        }

        public bool UpdateAUser(User updatedUser)
        {
            if (updatedUser == null)
                throw new ArgumentNullException("updatedUser");

            int idx = Users.FindIndex(b => b.Id == updatedUser.Id);
            if (idx == -1)
                return false;

            Users.RemoveAt(idx);
            Users.Add(updatedUser);
            return true;
        }

        public bool DeleteAUser(int UserId)
        {
            int idx = Users.FindIndex(b => b.Id == UserId);
            if (idx == -1)
                return false;

            Users.RemoveAll(b => b.Id == UserId);
            return true;
        }

        
    }
}