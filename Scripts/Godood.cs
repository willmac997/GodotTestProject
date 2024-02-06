using Godot;
using System;

public partial class Godood : Node2D
{
  private Vector2 _velocity = new Vector2(50, 20);
  private Node2D _sprite;
  private Node2D _blackhole;

  public override void _Ready()
  {
    _sprite = this;
	  _blackhole = GetNode<Node2D>("/root/Main/Blackhole");
  }

  public override void _PhysicsProcess(double delta)
  {
    Vector2 vectorA = _blackhole.Position - _sprite.Position;
    // float distance = vectorA.Length();
    Vector2 direction = vectorA.Normalized();
    Vector2 force = direction * 5; // direction / distance
    _velocity += force;
	  _sprite.Position += _velocity * (float)delta;
  }

  // public override void _Draw()
  // {
  //   Vector2 vectorA = _blackhole.Position - _sprite.Position;
  //   DrawLine(_sprite.Position, _blackhole.Position, new Color(1, 0, 0), 1);
  //   DrawLine(_sprite.Position, vectorA, new Color(0, 1, 0), 1);
  // }
}
