namespace Racer.Scenes
{
	using Racer.Contracts.Scenes;
	using Racer.Views;
	using System;

	public partial class TitleScene : Scene, IScene
	{
		public TitleScene()
		{
			this.View = new Button
			{
				Text = "New Game",
				Pressed = () => Console.WriteLine("Something happened!"),
			};
		}
	}
}
