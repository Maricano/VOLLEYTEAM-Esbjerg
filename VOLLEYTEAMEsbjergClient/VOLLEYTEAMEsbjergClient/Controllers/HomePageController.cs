using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceGateway;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class HomePageController : Controller
    {
        Facade facade = new Facade();
        // GET: HomePage
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewsIdex()
        {
            return View(facade.GetNewsGatewayService().ReadAll());
        }

        public ActionResult AboutIndex()
        {
            return View(facade.GetAboutGatewayService().ReadAll());
        }
    }

}