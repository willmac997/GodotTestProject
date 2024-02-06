using Godot;
using System;

public partial class Ball : StaticBody2D
{
  private Vector2 _velocity = new Vector2(1f, 0f);

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
    GD.Print("Balls ready lol");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
    // this.Position = _velocity * (float)delta;
	}
}
