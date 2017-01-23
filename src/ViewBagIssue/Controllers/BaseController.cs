using Microsoft.AspNetCore.Mvc;

namespace ViewBagIssue.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            ViewBag.Title = "Foo";
        }
    }
}
