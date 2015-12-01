using DtoModel;
using ServiceGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class BoardController : Controller
    {
        Facade facade = new Facade();

        // GET: Board
        public ActionResult Index()
        {
            return View(facade.GetBoardGatewayService().ReadAll());
        }

        // GET: Board/Details/5
        public ActionResult Details(int id)
        {
            return View(facade.GetBoardGatewayService().Read(id));
        }

        // GET: Board/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Board/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Board")] BoardDto boardDto)
        {
            try
            {
                facade.GetBoardGatewayService().Add(boardDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Board/Edit/5
        public ActionResult Edit(int id)
        {
            return View(facade.GetBoardGatewayService().Read(id));
        }

        // POST: Board/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Board")] BoardDto boardDto)
        {
            try
            {
                facade.GetBoardGatewayService().Update(boardDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Board/Delete/5
        public ActionResult Delete(int id)
        {
            return View(facade.GetBoardGatewayService().Read(id));
        }

        // POST: Board/Delete/5
        [HttpPost]
        public ActionResult Delete([Bind(Include = "Id, Board")] BoardDto boardDto)
        {
            try
            {
                facade.GetBoardGatewayService().Delete(boardDto.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
