using Microsoft.AspNetCore.Mvc;

namespace M2I_FirstAspNetApp.Controllers;

public class HomeController : Controller
{
	public IActionResult Index()
	{
		return View();
	}

	public IActionResult Privacy()
	{
		return View();
	}
}