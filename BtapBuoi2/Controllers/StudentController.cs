using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BtapBuoi2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Strudent
        public ActionResult Index()
        {
            TempData["Name"] = "Luka Modric";
            TempData["Age"] = "37";
            TempData["Address"] = "Croatia";
            return Redirect("ShowData");
        }

        public ActionResult ShowData()
        {
            return View();
        }
    }
}