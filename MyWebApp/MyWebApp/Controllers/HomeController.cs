using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using MyLibrary;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var entity = new MyEntity();
            var list = entity.GetList();
            var model = Mapper.Map<List<HomeViewModel>>(list);

            return View(model);
        }
    }
}
