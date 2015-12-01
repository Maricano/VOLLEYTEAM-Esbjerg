using DtoModel;
using ServiceGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class AboutController : Controller
    {
        Facade facade = new Facade();

        // GET: About
        public ActionResult Index()
        {
           
            return View(facade.GetAboutGatewayService().ReadAll());
        }

        // GET: About/Details/5
        public ActionResult Details(int id)
        {
            return View(facade.GetAboutGatewayService().Read(id));
        }

        // GET: About/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: About/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "About")] AboutDto aboutDto)
        {
            try
            {
                facade.GetAboutGatewayService().Add(aboutDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: About/Edit/5
        public ActionResult Edit(int id)
        {
            return View(facade.GetAboutGatewayService().Read(id));
        }

        // POST: About/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, About")] AboutDto aboutDto)
        {
            try
            {
                facade.GetAboutGatewayService().Update(aboutDto); 

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: About/Delete/5
        public ActionResult Delete(int id)
        {
            return View(facade.GetAboutGatewayService().Read(id));
        }

        // POST: About/Delete/5
        [HttpPost]
        public ActionResult Delete([Bind(Include = "Id, About")] AboutDto aboutDto)
        {
            try
            {
                facade.GetAboutGatewayService().Delete(aboutDto.Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
