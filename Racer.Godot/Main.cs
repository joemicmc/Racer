namespace Racer.Godot
{
	using global::Godot;
	using Racer.Engine;
	using Racer.Godot.Scenes;

	public partial class Main : Node
	{
		public override void _Ready()
		{
			_ = new Game(new SceneDrawer());
		}
	}
}