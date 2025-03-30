using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Part1.Models.ViewModels;

namespace Part1.Controllers
{
    public abstract class BasePageController<T> : 
        PageController<T> where T : PageData
    {
        public IActionResult RenderPage(T model)
        {
            var vm  = new PageViewModel<T>(model);
            return RenderPage(vm);           
        }
        public IActionResult RenderPage(PageViewModel<T> model)
        {         
            return View($"~/Views/Pages/{typeof(T).Name}.cshtml", model);
        }
    }
}
