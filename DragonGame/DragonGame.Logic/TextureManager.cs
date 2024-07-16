internal class TextureManager
{
  public static List<Texture2D> Textures { get; set; }
  public static Texture2D Circle;

  private static string _path = "TileSets\\";

  private static string TileSetsPath => ReturnPath();

  private static string ReturnPath()
  {
    string[] pathParts = Environment.CurrentDirectory.Split("\\");
    StringBuilder newPath = new();
    for (int i = 0; i < pathParts.Length - 3; i++)
      newPath.Append(pathParts[i] + "\\");
    newPath.Append("Content\\TileSets\\");
    return newPath.ToString();
  }

  internal static void Load(DragonGame dragonGame)
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
  }

  internal static void DrawCircle(int d, Vector2 position, Color color, SpriteBatch spriteBatch)
  {
    spriteBatch.Begin(samplerState: SamplerState.PointClamp);
    spriteBatch.Draw(Circle, new Rectangle((int)position.X, (int)position.Y, d, d), color);
    spriteBatch.End();
  }
}