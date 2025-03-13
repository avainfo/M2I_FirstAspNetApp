using M2I_FirstAspNetApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace M2I_FirstAspNetApp.Controllers;

public class TestController : Controller
{
	private static readonly List<string> Names =
	[
		"John",
		"Jane",
		"Jack",
		"Jill"
	];

	[HttpGet]
	public IActionResult Index()
	{
		return View(Names);
	}

	[HttpPost]
	public IActionResult Index(User user)
	{
		Names.Add(user.Name);
		return RedirectToAction("Index");
	}
}