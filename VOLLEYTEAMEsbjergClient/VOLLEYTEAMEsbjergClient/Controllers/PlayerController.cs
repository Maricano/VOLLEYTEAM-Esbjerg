using DtoModel;
using ServiceGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VOLLEYTEAMEsbjergClient.Models;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class PlayerController : Controller
    {

        Facade facade = new Facade();

        // GET: Player
        public ActionResult Index()
        {
            return View(facade.GetPlayerGatewayService().ReadAll());
        }

        // GET: Player/Details/5
        public ActionResult Details(int id)
        {
            return View(facade.GetPlayerGatewayService().Read(id));
        }

        // GET: Player/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Player/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "FirstName, LastName, Address, Email, Phone, TeamId, Training, Games, PlayerOfTheMatch")] PlayerDto playerDto)
        {
            try
            {
                facade.GetPlayerGatewayService().Add(playerDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Player/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Player/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, FirstName, LastName, Address, Email, Phone, Training, Games, PlayerOfTheMatch")] PlayerDto playerDto)
        {
            try
            {
                facade.GetPlayerGatewayService().Update(playerDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Player/Delete/5
        public ActionResult Delete(int id)
        {
            return View(facade.GetPlayerGatewayService().Read(id));
        }

        // POST: Player/Delete/5
        [HttpPost]
        public ActionResult Delete([Bind(Include = "Id")] PlayerDto playerDto)
        {
            try
            {
                facade.GetPlayerGatewayService().Delete(playerDto.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
