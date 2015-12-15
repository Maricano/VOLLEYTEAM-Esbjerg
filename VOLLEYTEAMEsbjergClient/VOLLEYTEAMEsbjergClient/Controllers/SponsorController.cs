using DtoModel;
using ServiceGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class SponsorController : Controller
    {
        Facade facade = new Facade(); 

        // GET: Sponsor
        public ActionResult Index()
        {
            return View(facade.GetSponsorGatewayService().ReadAll());
        }

        // GET: Sponsor/Details/5
        public ActionResult Details(int id)
        {
            return View(facade.GetSponsorGatewayService().Read(id));
        }

        // GET: Sponsor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sponsor/Create
        [HttpPost]
        public ActionResult Create([Bind ( Include = "Url, Name")] SponsorDto sponsorDto)
        {
            try
            {
                facade.GetSponsorGatewayService().Add(sponsorDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sponsor/Edit/5
        public ActionResult Edit(int id)
        {
            return View(facade.GetSponsorGatewayService().Read(id));
        }

        // POST: Sponsor/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind ( Include = "Id, Url, Name")] SponsorDto sponsorDto)
        {
            try
            {
                facade.GetSponsorGatewayService().Update(sponsorDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sponsor/Delete/5
        public ActionResult Delete(int id)
        {
            return View(facade.GetSponsorGatewayService().Read(id));
        }

        // POST: Sponsor/Delete/5
        [HttpPost]
        public ActionResult Delete([Bind ( Include = "Id")] SponsorDto sponsorDto)
        {
            try
            {
                facade.GetSponsorGatewayService().Delete(sponsorDto.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
