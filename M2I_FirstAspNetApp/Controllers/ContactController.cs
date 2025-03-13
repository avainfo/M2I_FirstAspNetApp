using M2I_FirstAspNetApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace M2I_FirstAspNetApp.Controllers;

public class ContactController : Controller
{
	private static readonly List<Contact> Contacts = [];
	private static int _id = 0;

	public IActionResult Index()
	{
		PageViewModel<List<Contact>, Contact> pvm = new PageViewModel<List<Contact>, Contact>
		{
			ItemList = Contacts,
			ItemType = new Contact()
		};

		return View(pvm);
	}

	public IActionResult Add(Contact contact)
	{
		contact.Id = _id++;
		Contacts.Add(contact);
		return RedirectToAction("Index");
	}

	public IActionResult Delete(int id)
	{
		Contacts.Remove(Contacts.First(contact => contact.Id == id));
		return RedirectToAction("Index");
	}
}