using Godot;
using System;

public partial class Paddle : StaticBody2D
{
  [Export]
  public bool isPlayer1 = true;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	if (isPlayer1)
	{
	  GD.Print("Hello player one");
	}
	else
	{
	  GD.Print("Hello player two");
	}
	}
}
