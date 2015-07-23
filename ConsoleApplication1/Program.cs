using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.ServiceReference1;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var srv = new UserServiceClient();
            var data = srv.GetUserList();
        }
    }
}
