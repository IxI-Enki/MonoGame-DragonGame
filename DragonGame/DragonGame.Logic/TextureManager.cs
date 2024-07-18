﻿internal class TextureManager
{
  public static void Load(DragonGame dragonGame)
  {
    Textures = new List<Texture2D>();
    Texture2D texture;
    texture = dragonGame.Content.Load<Texture2D>(_path + "16x48threeTiled");
    Textures.Add(texture);
    texture = dragonGame.Content.Load<Texture2D>(_path + "16x48threeTiled-wBackground");
    Textures.Add(texture);
    texture = dragonGame.Content.Load<Texture2D>(_path + "48x48nineTiled");
    Textures.Add(texture);
    texture = dragonGame.Content.Load<Texture2D>(_path + "48x48nineTiled-wBackground");
    Textures.Add(texture);
    //
    Circle = dragonGame.Content.Load<Texture2D>(_path + "32x32circle-white");
    Square = dragonGame.Content.Load<Texture2D>(_path + "32x32square");
  }

  #region methods
  private static string ReturnPath()
  {
    string[] pathParts = Environment.CurrentDirectory.Split("\\");
    StringBuilder newPath = new();
    for (int i = 0; i < pathParts.Length - 3; i++)
      newPath.Append(pathParts[i] + "\\");
    newPath.Append("Content\\TileSets\\");
    return newPath.ToString();
  }
  internal static void DrawCircle(int d, Vector2 position, Color color, SpriteBatch spriteBatch)
  {
    spriteBatch.Begin(samplerState: SamplerState.PointClamp);
    spriteBatch.Draw(Circle, new Rectangle((int)position.X, (int)position.Y, d, d), color);
    spriteBatch.End();
  }
  internal static void DrawSquareGrid(SpriteBatch spriteBatch)
  {
    spriteBatch.Begin(samplerState: SamplerState.PointClamp);
    for (int h = 0; h < WindowManager.Window.ClientBounds.Height; h += scaling)
      for (int w = 0; w < WindowManager.Window.ClientBounds.Width; w += scaling)
      {
        //   if (HeroInSquare(w, h))
        //     spriteBatch.Draw(Square, new Rectangle(w, h, scaling, scaling), Color.DarkOrange);
        if (MouseInSquare(w, h))
          spriteBatch.Draw(Square, new Rectangle(w, h, scaling, scaling), Color.Orange);
        else
          spriteBatch.Draw(Square, new Rectangle(w, h, scaling, scaling), Color.Gray);
      }
    spriteBatch.End();
  }
  #endregion methods

  #region properties
  public static List<Texture2D> Textures { get; set; }
  public static Texture2D Circle, Square;
  #endregion properties

  #region fields
  private static bool MouseInSquare(int w, int h)
    => Mouse.GetState().X >= w && Mouse.GetState().X < w + scaling
    && Mouse.GetState().Y >= h && Mouse.GetState().Y < h + scaling;
  private static string _path = "TileSets\\";
  private static int scaling => WindowManager.Window.ClientBounds.Width / 32;
  private static string TileSetsPath => ReturnPath();
  #endregion fields
}

#region outdated
/*
private static bool HeroInSquare(int w, int h)
  => Hero.entity.Position.X >= w && Hero.entity.Position.X < w + scaling
  && Hero.entity.Position.Y >= h && Hero.entity.Position.Y < h + scaling;
*/
#endregion outdated