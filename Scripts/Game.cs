using Godot;
using System;

public partial class Game : Node2D
{
	public override void _Process(double delta)
	{
    if (Input.IsActionPressed("Exit"))
    {
      GetTree().Quit();
    }
	}
}
