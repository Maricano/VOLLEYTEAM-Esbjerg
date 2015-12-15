using DtoModel;
using ServiceGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class RoleController : Controller
    {

        Facade facade = new Facade();

        // GET: Role
        public ActionResult Index()
        {
            return View(facade.GetRoleGatewayService().ReadAll());
        }

        // GET: Role/Details/5
        public ActionResult Details(int id)
        {
            return View(facade.GetRoleGatewayService().Read(id));
        }

        // GET: Role/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Role/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Role")] RoleDto roleDto)
        {
            try
            {
                facade.GetRoleGatewayService().Add(roleDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Role/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Role/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Role")] RoleDto roleDto)
        {
            try
            {
                facade.GetRoleGatewayService().Update(roleDto); 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Role/Delete/5
        public ActionResult Delete(int id)
        {
            return View(facade.GetRoleGatewayService().Read(id));
        }

        // POST: Role/Delete/5
        [HttpPost]
        public ActionResult Delete([Bind(Include = "Id")] RoleDto roleDto)
        {
            try
            {
                facade.GetRoleGatewayService().Delete(roleDto.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
