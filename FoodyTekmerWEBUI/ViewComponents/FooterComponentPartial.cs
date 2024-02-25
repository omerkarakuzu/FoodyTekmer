using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWEBUI.ViewComponents
{
    public class FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
