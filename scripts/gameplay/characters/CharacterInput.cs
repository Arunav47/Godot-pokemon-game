using Godot;


namespace Game.Gameplay
{
	public abstract partial class CharacterInput : Node
	{
		
		public override void _Ready()
		{
			Core.Logger.Info("Loading Character Input...");
		}
	}
}

