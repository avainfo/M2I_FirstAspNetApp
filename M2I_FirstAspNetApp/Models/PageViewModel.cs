namespace M2I_FirstAspNetApp.Models;

public class PageViewModel<T, TU>
{
	public T ItemList { get; set; }
	public TU ItemType { get; set; }
}