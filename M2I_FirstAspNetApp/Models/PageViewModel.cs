namespace M2I_FirstAspNetApp.Models;

public class PageViewModel<T, TU>
{
	public required T ItemList { get; init; }
	public required TU ItemType { get; init; }
}