namespace Racer.Scenes
{
	using Racer.Contracts.Scenes;
	using Racer.Data.Events;
	using Racer.Views;

	public class TitleScene : Scene, IScene
	{
		public TitleScene()
		{
			this.View = new Button
			{
				Text = "New Game",
				Pressed = () => Publish(new NewGamePressed()),
			};
		}
	}
}
