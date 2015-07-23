using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using MvcApplication1.UserService;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HomeTask()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddUser()
        {
            return PartialView("AddUser");
        }

        [HttpPost]
        public ActionResult AddUser(UserModel model)
        {
            return Json(model);
        }

        [HttpGet]
        public ActionResult UpdateUser()
        {
            return PartialView("UpdateUser");
        }
        [HttpPost]
        public ActionResult UpdateUser(UserModel model)
        {
            return Json(model);
        }

        [HttpGet]
        public ActionResult GetUserById()
        {
            return PartialView("GetUserById");
        }
        [HttpPost]
        public ActionResult GetUserById(UserModel model)
        {
            return Json(model);
        }
        [HttpGet]
        public ActionResult DeleteUser()
        {
            return PartialView("DeleteUser");
        }
        [HttpPost]
        public ActionResult DeleteUser(UserModel model)
        {
            return Json(model);
        }
    }
}
