using M2I_FirstAspNetApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace M2I_FirstAspNetApp.Controllers;

public class TodoController : Controller
{
	private static readonly List<Task> _tasks = []; 
	
	public IActionResult Index()
	{
		PageViewModel<List<Task>, Task> pageViewModel = new PageViewModel();
		return View(_tasks);
	}

	public IActionResult AddTask(Todo todo)
	{
		return RedirectToAction("Index");
	}
	
	public IActionResult EndTask()
	{
		return RedirectToAction("Index");
	}
}