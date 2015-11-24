using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class TournamentController : Controller
    {
        // GET: Tournament
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Tournament")] string tournament)
        {
            return View(tournament);
        }

        public ActionResult Edit(int id)
        {
            return View(id);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Tournament")] string tournament)
        {
            return View(tournament);
        }
    }
}