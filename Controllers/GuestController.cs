using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class GuestController : Controller
    {
        // GET: Guest
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string commentAuthorName, string commentText)
        {
            ViewBag.Title = commentAuthorName;
            ViewBag.Message = commentText;
            return View();
        }
    }
}