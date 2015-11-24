using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Contact")] string contact)
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View(id);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Contact")] string contact)
        {
            return View();
        }
    }
}