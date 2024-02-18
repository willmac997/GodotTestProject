using Godot;
using System;

public partial class Paddle : StaticBody2D
{
  [Export]
  public bool isPlayer1 = true;
  [Export]
  private float _speed = 150f;

  private Vector2 _velocity = new Vector2(0f, 0f);


  public override void _Process(double delta)
  {
    _velocity.Y = 0;
    if (isPlayer1)
    {
      if (Input.IsActionPressed("P1_Up")) _velocity.Y -= _speed;
      if (Input.IsActionPressed("P1_Down")) _velocity.Y += _speed;
    }
    else
    {
      if (Input.IsActionPressed("P2_Up")) _velocity.Y -= _speed;
      if (Input.IsActionPressed("P2_Down")) _velocity.Y += _speed;
    }
  }


  public override void _PhysicsProcess(double delta)
  {
    Position += _velocity * (float)delta;
  }
}
