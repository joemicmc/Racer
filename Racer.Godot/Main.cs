namespace Racer.Godot
{
	using global::Godot;
	using Racer.Contracts.Scenes;
	using Racer.Engine;
	using Racer.Engine.Containers;
	using Racer.Godot.Scenes;

	public partial class Main : Node
	{
		public override void _Ready()
		{
			GraphicsContainer.Register<ISceneDrawer>(new SceneDrawer());

			_ = new Game();
		}
	}
}