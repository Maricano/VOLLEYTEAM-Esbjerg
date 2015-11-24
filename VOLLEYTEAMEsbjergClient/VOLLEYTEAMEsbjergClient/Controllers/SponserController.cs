using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class SponserController : Controller
    {
        // GET: Sponser
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Sponser")] string sponser)
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Sponser")] string sponser)
        {
            return View();
        }



        }
}