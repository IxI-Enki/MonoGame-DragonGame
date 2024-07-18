public class GameManager
{
  #region constructor
  public GameManager()
  {
    _map = new();
  }
  #endregion constructor

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

  #region fields
  private readonly Map _map;

  #endregion fields
}