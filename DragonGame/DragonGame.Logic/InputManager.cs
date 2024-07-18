public static class InputManager
{
  #region methods
  public static void Update()
  {
    var keyboardState = Keyboard.GetState();
    if (keyboardState.IsKeyDown(Keys.W)) _direction.Y--;
    if (keyboardState.IsKeyDown(Keys.S)) _direction.Y++;
    if (keyboardState.IsKeyDown(Keys.A)) _direction.X--;
    if (keyboardState.IsKeyDown(Keys.D)) _direction.X++;
    //
    if (_direction != Vector2.Zero) _direction.Normalize();
  }
  #endregion methods

  #region properties
  public static Vector2 Direction => _direction;
  #endregion properties

  #region fields
  private static Vector2 _direction;
  #endregion fields
}