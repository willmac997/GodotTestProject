using Godot;
using System;

public partial class Ball : StaticBody2D
{
  [Export]
  private float _speed = 200f;
  private Vector2 _velocity = new Vector2(0f, 0f);

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
    _velocity.X = _speed;
    Position += _velocity * (float)delta;
	}
}
