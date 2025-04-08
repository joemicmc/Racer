namespace Racer.Engine
{
	using Racer.Contracts.Scenes;
	using Racer.Engine.Scenes;

	public class Game
	{
		private IScene Scene { get; set; }

		public Game()
		{
			this.Scene = new TitleScene();

			this.Scene.Draw();
		}
	}
}
