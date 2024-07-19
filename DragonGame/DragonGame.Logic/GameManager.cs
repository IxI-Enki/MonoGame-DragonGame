public class GameManager
{
  #region constructor
  public GameManager()
  {
    _map = new();
    _hero = 
      new
      (
        Globals.Content.Load<Texture2D>(TextureManager.ReturnPath() + "hero"),
        new
        (
          Globals.WindowSize.X / 2, 
          Globals.WindowSize.Y / 2
        )
      );
    _hero.SetBounds(_map.MapSize, _map.TileSize);
  }
  #endregion

  #region methods
  public void Update()
  {
    InputManager.Update();
    _hero.Update();
    CalculateTranslation();
  }
  public void Draw()
  {
    Globals.SpriteBatch.Begin(transformMatrix: _translation);
    _map.Draw();
    _hero.Draw();
    Globals.SpriteBatch.End();
  }
  private void CalculateTranslation()
  {
    var dx = (Globals.WindowSize.X / 2) - _hero.Position.X;
    dx = MathHelper.Clamp(dx, -_map.MapSize.X + Globals.WindowSize.X + (_map.TileSize.X / 2), _map.TileSize.X / 2);
    var dy = (Globals.WindowSize.Y / 2) - _hero.Position.Y;
    dy = MathHelper.Clamp(dy, -_map.MapSize.Y + Globals.WindowSize.Y + (_map.TileSize.Y / 2), _map.TileSize.Y / 2);
    _translation = Matrix.CreateTranslation(dx, dy, 0f);
  }
  #endregion

  #region fields
  private readonly Map _map;
  private readonly Hero _hero;
  private Matrix _translation;
  #endregion
}