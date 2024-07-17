internal static class Hero
{
  public static Entity entity;

  static Hero()
  => entity = new()
  {
    Position = new Vector2(20f, 20f),
    Sprite = 'x'
  };
}