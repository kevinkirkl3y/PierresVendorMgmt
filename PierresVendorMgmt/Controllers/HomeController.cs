using Microsoft.AspNetCore.Mvc;

namespace PierresVendorMgmt.Controllers
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