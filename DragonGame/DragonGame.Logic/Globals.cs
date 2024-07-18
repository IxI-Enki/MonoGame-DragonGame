﻿
public static class Globals
{
  public static float Time { get; set; }
  public static ContentManager Content { get; set; }
  public static SpriteBatch SpriteBatch { get; set; }

  public static Point WindowSize { get; set; }
  public static void Update(GameTime gameTime) { Time = (float)gameTime.TotalGameTime.TotalSeconds; }
}

