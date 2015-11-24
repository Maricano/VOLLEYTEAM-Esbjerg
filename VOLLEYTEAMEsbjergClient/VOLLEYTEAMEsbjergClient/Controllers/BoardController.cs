using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Board")] string board)
        {
            return View();
        }

        public ActionResult Edit(int Id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit([Bind (Include = "Id, Board")] string board)
        {
            return View();
        }
            

    }
}