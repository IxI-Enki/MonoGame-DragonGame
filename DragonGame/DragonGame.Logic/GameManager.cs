public class GameManager
{
  #region constructor
  public GameManager()
  {
    _map = new();
  }
  #endregion constructor

  #region methods
  public void Update()
  {
    InputManager.Update();
  }
  public void Draw()
  {
    Globals.SpriteBatch.Begin();
    _map.Draw();
    Globals.SpriteBatch.End();
  }
  #endregion methods

  #region fields
  private readonly Map _map;

  #endregion fields
}