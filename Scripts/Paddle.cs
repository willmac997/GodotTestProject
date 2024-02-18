using Godot;
using System;

public partial class Paddle : StaticBody2D
{
  [Export]
  public bool isPlayer1 = true;
  [Export]
  private float _speed = 150f;

  private Vector2 _velocity = new Vector2(0f, 0f);
  private string _upKey;
  private string _downKey;

  public override void _Ready()
  {
    _upKey = isPlayer1 ? "P1_Up" : "P2_Up";
    _downKey = isPlayer1 ? "P1_Down" : "P2_Down";
  }

  public override void _Process(double delta)
  {
    _velocity.Y = 0;
    if (Input.IsActionPressed(_upKey)) _velocity.Y -= _speed;
    if (Input.IsActionPressed(_downKey)) _velocity.Y += _speed;
  }

  public override void _PhysicsProcess(double delta)
  {
    Position += _velocity * (float)delta;
  }
}
