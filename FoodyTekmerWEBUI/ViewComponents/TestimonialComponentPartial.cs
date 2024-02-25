using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWEBUI.ViewComponents
{
    public class TestimonialComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
