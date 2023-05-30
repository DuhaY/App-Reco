using GameRecomWebProject.Models;
using GameRecomWebProject.Models.BusinessLogic.Abstract;
using GameRecomWebProject.Models.BusinessLogic.Concrete;
using GameRecomWebProject.Models.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using NuGet.Packaging.Signing;

namespace GameRecomWebProject.Controllers
{
    public class AppController : Controller
    {
        IAppService _appMngr;
        List<string> filters = new List<string>();

        public AppController(IAppService appMngr)
        {
            _appMngr = appMngr;
            
        }

        //istemciyi soru viewine yönlendirir.
        [HttpGet]
        public ActionResult Questions()
        {
            return View();
        }

        //Questions HttpGet isteğinden gelen etiket listesini işler, istemciyi showGames viewine yönlendirir.
        [HttpPost]
        public ActionResult Questions(string[] tagList)
        {
            List<AppList> list = new List<AppList>();
            foreach (var tag in tagList)
            {
                list.Add(_appMngr.GetApp(tag).Data);
            }

            ViewBag.Apps = list;
            return View("showGames");
        }

    }
}
