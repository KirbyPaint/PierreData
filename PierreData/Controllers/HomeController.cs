using Microsoft.AspNetCore.Mvc;

namespace PierreData.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}