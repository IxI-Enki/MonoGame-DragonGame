internal class Hero
{
  public Entity entity;

  public Hero() 
    => entity = new()
  {
    Position = new Vector2(20f, 20f),
    Sprite = 'x'
  };
}