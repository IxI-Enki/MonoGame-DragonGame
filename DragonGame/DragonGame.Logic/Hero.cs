public class Hero : Sprite
{
  #region constructor
  public Hero(Texture2D texture, Vector2 position) : base(texture, position)
  {
  }
  #endregion constructor

  #region methods
  public void SetBounds(Point mapSize, Point tileSize)
  {
    _minPos = new(
      (-tileSize.X / 2) + Origin.X, (-tileSize.Y / 2) + Origin.Y);
    _maxPos = new(
      mapSize.X - (tileSize.X / 2) - Origin.X,
      mapSize.Y - (tileSize.Y / 2) - Origin.Y);
  }

  public void Update()
  {
    Position += InputManager.Direction * Globals.Time * SPEED;
    Position = Vector2.Clamp(Position, _minPos, _maxPos);
  }
  #endregion methods

  #region fields
  private const float SPEED = 500;
  private Vector2
    _minPos,
    _maxPos;
  #endregion fields
}

#region outdated
/* public static Entity entity;

 static Hero()
 => entity = new()
 {
   Position = new Vector2(20f, 20f),
   Sprite = 'x'
 };
*/
#endregion outdated