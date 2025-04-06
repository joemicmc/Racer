namespace Racer
{
	using Godot;
	using Racer.Contracts;
	using Racer.Contracts.Scenes;
	using Racer.Scenes;

	public partial class Game : IGame
	{
		public IScene Scene { get; set; }

		public Game()
		{
			this.Scene = new TitleScene();
		}

		public Node GetNode()
		{
			var node = new Node();

			node.AddChild(this.Scene.GetNode());

			return node;
		}
	}
}
