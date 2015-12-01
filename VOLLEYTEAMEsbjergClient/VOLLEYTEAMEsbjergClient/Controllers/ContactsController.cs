using DtoModel;
using ServiceGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class ContactsController : Controller
    {
        Facade facade = new Facade();

        // GET: Contacts
        public ActionResult Index()
        {
            return View(facade.GetContactGatewayService().ReadAll());
        }

        // GET: Contacts/Details/5
        public ActionResult Details(int id)
        {
            return View(facade.GetContactGatewayService().Read(id));
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Contacts")] ContactsDto contactsDto )
        {
            try
            {
                facade.GetContactGatewayService().Add(contactsDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contacts/Edit/5
        public ActionResult Edit(int id)
        {
            return View(facade.GetContactGatewayService().Read(id));
        }

        // POST: Contacts/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Contacts")] ContactsDto contactsDto)
        {
            try
            {
                facade.GetContactGatewayService().Update(contactsDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contacts/Delete/5
        public ActionResult Delete(int id)
        {
            return View(facade.GetContactGatewayService().Read(id));
        }

        // POST: Contacts/Delete/5
        [HttpPost]
        public ActionResult Delete([Bind(Include = "Id, Contacts")] ContactsDto contactsDto)
        {
            try
            {
                facade.GetContactGatewayService().Delete(contactsDto.Id); 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
