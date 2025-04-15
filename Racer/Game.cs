namespace Racer
{
	using Godot;
	using Racer.Contracts;
	using Racer.Contracts.Scenes;
	using Racer.Data.Events;
	using Racer.Scenes;
	using System;

	public class Game : Component, IGame
	{
		public IScene Scene { get; set; }

		public Game()
		{
			this.Scene = new TitleScene();

			this.Subscribe<NewGamePressed>((x) => Console.WriteLine("New game pressed!"));
		}

		public Node GetNode()
		{
			var node = new Node();

			node.AddChild(this.Scene.GetNode());

			return node;
		}
	}
}
