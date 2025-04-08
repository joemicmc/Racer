namespace Racer.Engine.Scenes
{
	using Racer.Contracts.Scenes;
	using Racer.Engine.Containers;

	public class Scene : IScene
	{
		public virtual string Name => string.Empty;

		public void Draw()
		{
			var sceneDrawer = GraphicsContainer.Resolve<ISceneDrawer>();

			sceneDrawer.Draw(this);
		}
	}
}
