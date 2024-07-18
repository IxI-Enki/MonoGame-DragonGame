 public static class InputManager
{
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

  // properties:
  public static Vector2 Direction => _direction;
  
  // fields:
  private static Vector2 _direction;
}

