using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "About")] string about)
        {
            //try
            //{
                
            //        Redirect.
            //}
            return View(about);
        }

        public ActionResult Edit(int id)
        {
            return View(id);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, About")] string about)
        {
            return View(about);
        }
    }
}