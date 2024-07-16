
internal class TextureManager
{
  public static List<Texture2D> Textures { get; set; }
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

  }
}