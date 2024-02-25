using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWEBUI.ViewComponents
{
    public class ScriptComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
