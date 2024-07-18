public class Sprite
{
  #region constructor
  public Sprite(Texture2D texture, Vector2 position)
  {
    _texture = texture;
    Position = position;
    Origin = new
    (
      _texture.Width / 2,
      texture.Height / 2
    );
  }
  #endregion constructor

  #region methods
  public void Draw() => Globals.SpriteBatch.Draw
  (
    _texture,
    Position,
    null,
    Color.White,
    0f,
    Origin,
    1f,
    SpriteEffects.None,
    0f
  );
  #endregion methods

  #region properties
  public Vector2 Position { get; protected set; }
  public Vector2 Origin { get; protected set; }
  #endregion properties

  #region fields
  private readonly Texture2D _texture;
  #endregion fields
}