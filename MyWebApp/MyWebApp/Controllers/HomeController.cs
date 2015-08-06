using System.Collections.Generic;
using System.Web.Mvc;
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
            var model = new List<HomeViewModel>();
            foreach (var valueObject in list)
            {
                model.Add(new HomeViewModel
                          {
                              Name = valueObject.Name,
                              Company = valueObject.Company,
                              Url = valueObject.Url,
                          });
            }

            return View(model);
        }
    }
}
