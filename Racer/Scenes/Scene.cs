namespace Racer.Scenes
{
	using Godot;
	using Racer.Contracts.Scenes;
	using Racer.Contracts.Views;

	public class Scene : Component, IScene
	{
		public IView View { get; set; }

		public Node GetNode()
		{
			var node = new Node();

			node.AddChild(this.View.GetControl());

			return node;
		}
	}
}
