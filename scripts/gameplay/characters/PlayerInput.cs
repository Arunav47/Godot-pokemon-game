using Godot;


namespace Game.Gameplay
{
	public partial class PlayerInput : Node
	{
		[ExportCategory("Player Input")]
		[Export] public double HoldThreshold = 0.1f;
		[Export] public double HoldTime = 0.0f;
		public override void _Ready()
		{
			Core.Logger.Info("Loading Player Input...");
		}

	}
}

