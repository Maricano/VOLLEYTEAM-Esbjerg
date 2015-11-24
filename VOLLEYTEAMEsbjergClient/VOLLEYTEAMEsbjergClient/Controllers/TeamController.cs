using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Team")] string team)
        {
            return View(team);
        }

        public ActionResult Edit(int id)
        {
            return View(id);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Team")] string team)
        {
            return View(team);
        }
    }
}