using M2I_FirstAspNetApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace M2I_FirstAspNetApp.Controllers;

public class TodoController : Controller
{
	private static readonly List<Todo> Tasks = [];
	private static int _id = 0;

	public IActionResult Index()
	{
		PageViewModel<List<Todo>, Todo> pvm = new PageViewModel<List<Todo>, Todo>
		{
			ItemList = Tasks,
			ItemType = new Todo()
		};
		return View(pvm);
	}

	public IActionResult AddTask(Todo todo)
	{
		todo.Id = _id++;
		Tasks.Add(todo);
		Console.WriteLine(todo.IsDone);
		return RedirectToAction("Index");
	}

	public IActionResult EndTask(int id)
	{
		Todo todo = Tasks.First(todo => todo.Id == id);
		todo.IsDone = !todo.IsDone;
		return RedirectToAction("Index");
	}
}