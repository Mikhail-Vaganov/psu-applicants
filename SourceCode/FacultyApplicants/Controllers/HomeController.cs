using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FacultyApplicants.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Приемная комиссия физического факультета";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "О приложении «Абитуриенты физфака»";
            ViewBag.Message = "Шаблонное приложение для курса ASP.NET MVC + Oracle Database";
            ViewBag.Content = "Приложение предназначено для информирования поступающих на физический факультет о текущем рейтинге абитуриентов.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Контакты";
            return View();
        }
    }
}