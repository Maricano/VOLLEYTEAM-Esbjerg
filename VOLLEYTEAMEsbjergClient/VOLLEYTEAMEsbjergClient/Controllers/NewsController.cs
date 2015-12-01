using DtoModel;
using ServiceGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class NewsController : Controller
    {
        Facade facade = new Facade();

        // GET: News
        public ActionResult Index()
        {
            return View(facade.GetNewsGatewayService().ReadAll());
        }

        // GET: News/Details/5
        public ActionResult Details(int id)
        {
            return View(facade.GetNewsGatewayService().Read(id));
        }

        // GET: News/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: News/Create
        [HttpPost]
        public ActionResult Create([Bind ( Include = "News")] NewsDto newsDto)
        {
            try
            {
                facade.GetNewsGatewayService().Add(newsDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: News/Edit/5
        public ActionResult Edit(int id)
        {
            return View(facade.GetNewsGatewayService().Read(id));
        }

        // POST: News/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind ( Include = "Id, News" )] NewsDto newsDto)
        {
            try
            {
                facade.GetNewsGatewayService().Update(newsDto); 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: News/Delete/5
        public ActionResult Delete(int id)
        {
            return View(facade.GetNewsGatewayService().Read(id));
        }

        // POST: News/Delete/5
        [HttpPost]
        public ActionResult Delete([Bind ( Include = "Id, News")] NewsDto newsDto)
        {
            try
            {
                facade.GetNewsGatewayService().Delete(newsDto.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
