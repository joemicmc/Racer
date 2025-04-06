namespace Racer.Contracts.Scenes
{
	using Godot;
	using Racer.Contracts.Views;

	public interface IScene
	{
		IView View { get; set; }

		Node GetNode();
	}
}
