using Ewidencja.Model.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ewidencja.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dbinit = new DBInitializerService();
            dbinit.InitializeDB(Server.MapPath("~/Content/oldData/PACJENCI.GDB"));

            return View();
        }

        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
           

            return View();
        }
    }
}
