internal class TextureManager
{
  #region methods
  public static void Load(DragonGame dragonGame)
  {
    string[] _textures = [
      "16x48threeTiled",
      "16x48threeTiled-wBackground",
      "48x48nineTiled",
      "48x48nineTiled-wBackground"
      ];

    Textures = [];
    foreach (string s in _textures)
      Textures.Add(dragonGame.Content.Load<Texture2D>(_path + s));

    //
    Circle = dragonGame.Content.Load<Texture2D>(_path + "32x32circle-white");
    Square = dragonGame.Content.Load<Texture2D>(_path + "32x32square");
  }
  public static string ReturnPath()
  {
    string[] pathParts = Environment.CurrentDirectory.Split("\\");
    StringBuilder newPath = new();
    for (int i = 0; i < pathParts.Length - 3; i++)
      newPath.Append(pathParts[i] + "\\");
    newPath.Append("bin\\Debug\\net6.0\\Content\\TileSets\\");
    return newPath.ToString();
  }
  //
  private static bool MouseInSquare(int w, int h)
    => Mouse.GetState().X >= w && Mouse.GetState().X < w + scaling
    && Mouse.GetState().Y >= h && Mouse.GetState().Y < h + scaling;
  //
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
  #endregion  

  #region properties
  public static List<Texture2D> Textures { get; set; }
  public static Texture2D Circle, Square;
  #endregion  

  #region fields
  private static string _path = "TileSets\\";
  private static int scaling => WindowManager.Window.ClientBounds.Width / 32;
  private static string TileSetsPath => ReturnPath();
  #endregion  
}

#region outdated
/*
private static bool HeroInSquare(int w, int h)
  => Hero.entity.Position.X >= w && Hero.entity.Position.X < w + scaling
  && Hero.entity.Position.Y >= h && Hero.entity.Position.Y < h + scaling;
*/
#endregion outdated