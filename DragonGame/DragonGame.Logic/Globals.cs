public static class Globals
{
  public static void Update(GameTime gameTime)
    => Time = (float)gameTime.ElapsedGameTime.TotalSeconds;

  #region properties
  public static float Time { get; set; }
  public static ContentManager Content { get; set; }
  public static SpriteBatch SpriteBatch { get; set; }
  public static Point WindowSize { get; set; }
  #endregion  
}