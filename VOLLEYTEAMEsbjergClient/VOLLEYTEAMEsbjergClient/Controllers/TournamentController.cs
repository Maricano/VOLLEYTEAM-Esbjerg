﻿using DtoModel;
using ServiceGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class TournamentController : Controller
    {
        Facade facade = new Facade();

        // GET: Tournament
        public ActionResult Index()
        {
            return View(facade.GetTournamentGatewayService().ReadAll());
        }

        // GET: Tournament/Details/5
        public ActionResult Details(int id)
        {
            return View(facade.GetTournamentGatewayService().Read(id));
        }

        // GET: Tournament/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tournament/Create
        [HttpPost]
        public ActionResult Create([Bind ( Include = "Tournament")] TournamentDto tournamentDto) 
        {
            try
            {
                facade.GetTournamentGatewayService().Add(tournamentDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tournament/Edit/5
        public ActionResult Edit(int id)
        {
            return View(facade.GetTournamentGatewayService().Read(id));
        }

        // POST: Tournament/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind ( Include = "Id, Tournament")] TournamentDto tournamentDto)
        {
            try
            {
                facade.GetTournamentGatewayService().Update(tournamentDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tournament/Delete/5
        public ActionResult Delete(int id)
        {
            return View(facade.GetTournamentGatewayService().Read(id));
        }

        // POST: Tournament/Delete/5
        [HttpPost]
        public ActionResult Delete([Bind ( Include = "Id, Tournament")] TournamentDto tournamentDto)
        {
            try
            {
                facade.GetTournamentGatewayService().Delete(tournamentDto.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
