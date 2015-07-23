using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        static IUserRepository repository = new UserRepository();
        public List<User> GetUserList()
        {
            return repository.GetAllUsers();
        }
        public User GetUserById(string id)
        {
            return repository.GetUserById(int.Parse(id));
        }
        public string AddUser(User User, string id)
        {
            User newUser = repository.AddNewUser(User);
            return "id=" + newUser.Id;
        }

        public string UpdateUser(User User, string id)
        {
            bool updated = repository.UpdateAUser(User);
            if (updated)
                return "User with id = " + id + " updated successfully";
            else
                return "Unable to update User with id = " + id;

        }

        public string DeleteUser(string id)
        {
            bool deleted = repository.DeleteAUser(int.Parse(id));
            if (deleted)
                return "User with id = " + id + " deleted successfully.";
            else
                return "Unable to delete User with id = " + id;
        }

        public void OptionsHandler()
        {

        }
    }
}
