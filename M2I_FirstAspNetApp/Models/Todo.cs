namespace M2I_FirstAspNetApp.Models;

public class Todo
{
	public int Id { get; set; }
	public string Title { get; set; } = "";
	public bool IsDone { get; set; } = false;
}