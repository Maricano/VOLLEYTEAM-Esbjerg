using DtoModel;
using ServiceGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class TeamController : Controller
    {
        Facade facade = new Facade();

        // GET: Team
        public ActionResult Index()
        {
            return View(facade.GetTeamGatewayService().ReadAll());
        }

        // GET: Team/Details/5
        public ActionResult Details(int id)
        {
            return View(facade.GetTeamGatewayService().Read(id));
        }

        // GET: Team/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Team/Create
        [HttpPost]
        public ActionResult Create([Bind ( Include = "Team")] TeamDto teamDto)
        {
            try
            {
                facade.GetTeamGatewayService().Add(teamDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Team/Edit/5
        public ActionResult Edit(int id)
        {
            return View(facade.GetTeamGatewayService().Read(id));
        }

        // POST: Team/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind ( Include = "Id, Team")] TeamDto teamDto)
        {
            try
            {
                facade.GetTeamGatewayService().Add(teamDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Team/Delete/5
        public ActionResult Delete(int id)
        {
            return View(facade.GetTeamGatewayService().Read(id));
        }

        // POST: Team/Delete/5
        [HttpPost]
        public ActionResult Delete([Bind ( Include = "Id, Team")] TeamDto teamDto)
        {
            try
            {
                facade.GetTeamGatewayService().Delete(teamDto.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
