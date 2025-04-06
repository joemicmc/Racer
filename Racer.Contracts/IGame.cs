namespace Racer.Contracts
{
	using Godot;
	using Racer.Contracts.Scenes;

	public interface IGame
	{
		IScene Scene { get; set; }

		public Node GetNode();
	}
}
