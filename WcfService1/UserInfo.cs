using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Phone { get; set; }
    }

    //public partial class Users
    //{
    //    private static readonly Users _instance = new Users();
    //    private Users() { }
    //    public static Users Instance
    //    {
    //        get { return _instance; }
    //    }
    //    public List<User> UsersList
    //    {
    //        get { return users; }
    //    }
    //    private List<User> users = new List<User>()
    //    {
    //        new User(){Id = 0, Name = "Christa Becker", Phone = "+1 (968) 417-2451"},
    //        new User(){Id = 1, Name = "Sawyer Guthrie", Phone = "+1 (946) 514-2633"},
    //        new User(){Id = 2, Name = "Snider Patterson", Phone = "+1 (916) 490-3989"},
    //        new User(){Id = 3, Name = "Mcconnell Gill", Phone = "+1 (889) 495-3063"},
    //        new User(){Id = 4, Name = "Estella Carroll", Phone = "+1 (961) 580-3847"},
    //        new User(){Id = 5, Name = "Darla Mullins", Phone = "+1 (901) 510-3012"},
    //        new User(){Id = 6, Name = "Beck Riggs", Phone = "+1 (888) 574-3516"}
    //    };

    //}
}