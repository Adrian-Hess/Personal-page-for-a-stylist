using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stylist_Website_V5.Models;
using System.Data.Entity;

namespace Stylist_Website_V5.Controllers
{
    public class HomeController : Controller
    {
        CallBackContext db = new CallBackContext();
        public ActionResult Index()
        {
            IEnumerable<CallBack> callBacks = db.CallBacks;
            ViewBag.CallBacks = callBacks;
            return View();
        }

        [HttpGet]
        public ActionResult Reg()
        {
            Guid id = Guid.NewGuid();
            ViewBag.CallBackId = id;
            return View("Reg");
        }

        [HttpPost]
        public ActionResult Reg(CallBack callBack)
        {
            if (ModelState.IsValid)
            {
                callBack.Id = Guid.NewGuid();
                db.CallBacks.Add(callBack);
                db.SaveChanges();
            }

            return View("Reg");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}