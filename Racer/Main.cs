namespace Racer
{
	using Godot;

	public partial class Main : Node
	{
		public override void _Ready()
		{
			var game = new Game();

			this.AddChild(game.GetNode());
		}
	}
}