namespace Racer.Godot.Scenes
{
	using global::Godot;
	using Racer.Contracts.Scenes;

	public class SceneDrawer : ISceneDrawer
	{
		public void Draw(IScene scene)
		{
			GD.Print(scene.Name);
		}
	}
}
