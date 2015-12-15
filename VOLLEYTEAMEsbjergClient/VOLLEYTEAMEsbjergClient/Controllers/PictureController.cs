using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DtoModel;
using ServiceGateway;
using VOLLEYTEAMEsbjergClient.Models;

namespace VOLLEYTEAMEsbjergClient.Controllers
{
    public class PictureController : Controller
    {
        Facade facade = new Facade();

        // GET: Picture
        public ActionResult Index()
        {
            var pictureDtos = facade.GetPictureGatewayService().ReadAll();
            var picList = new List<PictureViewModel>();
            foreach (var pictureDto in pictureDtos)
            {
                picList.Add(new PictureViewModel() { PictureString = "data:image/png;base64," + Convert.ToBase64String(pictureDto.Picture), PictureName = pictureDto.PictureName, Id = pictureDto.Id });
            }
            return View(picList);
        }

        public ActionResult Details(int id)
        {
            var pictureDto = facade.GetPictureGatewayService().Read(id);
            var model = new PictureViewModel()
            {
                Id = pictureDto.Id,
                PictureString = "base:image/png;base64," + Convert.ToBase64String(pictureDto.Picture),
                PictureName = pictureDto.PictureName
            };
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Picture, PictureName")] PictureDto pictureDto)
        {
            try
            {
                facade.GetPictureGatewayService().Add(pictureDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View(facade.GetPictureGatewayService().Read(id));
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Picture, PictureName")] PictureDto pictureDto)
        {
            try
            {
                facade.GetPictureGatewayService().Update(pictureDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View(facade.GetPictureGatewayService().Read(id));
        }

        [HttpPost]
        public ActionResult Delete([Bind(Include = "Id, Picture, PictureName")] PictureDto pictureDto)
        {
            try
            {
                facade.GetPictureGatewayService().Delete(pictureDto.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}