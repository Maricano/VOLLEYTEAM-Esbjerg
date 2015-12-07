using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DtoModel;
using ServiceGateway;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class EnglishController : Controller
    {
        Facade facade = new Facade();
        // GET: English
        public ActionResult Index()
        {
            return View(facade.GetEnglishGatewayService().ReadAll());
        }

        // GET: English/Details/5
        public ActionResult Details(int id)
        {
            return View(facade.GetEnglishGatewayService().Read(id));
        }

        // GET: English/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: English/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "English")]EnglishDto englishDto)
        {
            try
            {
                facade.GetEnglishGatewayService().Add(englishDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: English/Edit/5
        public ActionResult Edit(int id)
        {
            return View(facade.GetEnglishGatewayService().Read(id));
        }

        // POST: English/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind (Include = "English")]EnglishDto englishDto)
        {
            try
            {
                facade.GetEnglishGatewayService().Update(englishDto);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: English/Delete/5
        public ActionResult Delete(int id)
        {
            return View(facade.GetEnglishGatewayService().Read(id));
        }

        // POST: English/Delete/5
        [HttpPost]
        public ActionResult Delete([Bind(Include = "English")] EnglishDto englishDto)
        {
            try
            {
                facade.GetEnglishGatewayService().Delete(englishDto.Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
