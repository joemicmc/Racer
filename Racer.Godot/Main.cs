namespace Racer.Godot
{
	using global::Godot;
	using Racer.Engine;

	public partial class Main : Node
	{
		public override void _Ready()
		{
			base._Ready();

			GD.Print(new Scene().Name);
		}
	}
}