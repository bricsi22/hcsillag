using Microsoft.AspNetCore.Mvc;

namespace Hajnalcsillag.Controllers{
    public class HomeController : Controller
    {
        public ViewResult Index(){
            return View();
        }
    }
}