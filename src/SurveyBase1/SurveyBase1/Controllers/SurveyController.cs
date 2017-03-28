using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurveyBase1.Controllers
{
    public class SurveyController : Controller
    {
        // GET: Survey
        public ActionResult Landing()
        {
            return View();
        }

        public ActionResult Workflow()
        {
            return View();
        }

        public ActionResult BaseInfo1()
        {
            return View();
        }
    }
}