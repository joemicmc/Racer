namespace Racer.Engine
{
	using Racer.Contracts.Scenes;
	using Racer.Engine.Scenes;

	public class Game
	{
		private IScene Scene { get; set; }

		public Game(ISceneDrawer sceneDrawer)
		{
			this.Scene = new TitleScene();

			sceneDrawer.Draw(this.Scene);
		}
	}
}
