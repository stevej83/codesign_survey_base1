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
            Guid guid = Guid.NewGuid();
            string str = guid.ToString();
            ViewBag.Message = str;
            return View();
        }

        /*public string Test()
        {
            return "Test...";
        }*/

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
