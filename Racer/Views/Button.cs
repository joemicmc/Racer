namespace Racer.Views
{
	using Godot;
	using Racer.Contracts.Views;
	using System;

	public partial class Button : IButton
	{
		public string Text { get; set; }

		public Action Pressed { get; set; }

		public Control GetControl()
		{
			var button = new Godot.Button
			{
				Text = this.Text
			};

			button.Pressed += this.Pressed;

			return button;
		}
	}
}
