using Microsoft.AspNetCore.Mvc;

namespace MVCDotNetLearning.Controllers;

public class MessageController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}