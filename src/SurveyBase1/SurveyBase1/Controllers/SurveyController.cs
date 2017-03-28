using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SurveyBase1.Models;
using System.Configuration;
using System.Threading.Tasks;

namespace SurveyBase1.Controllers
{
    public class SurveyController : Controller
    {
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
