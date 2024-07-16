interface IEntity
{
  public Vector2 Position { get; set; }
  public char Sprite { get; set; }
  //´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´
  internal float Health { get; set; }
}
//

class Entity : IEntity
{
  private Vector2 _pos;
  private float _health;
  private char _sprite;
  ///´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´
  public char Sprite { get => _sprite; set => _sprite = value; }
  public Vector2 Position { get => _pos; set => _pos = value; }
  //´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´
  float IEntity.Health { get => _health; set => _health = value; }
}

