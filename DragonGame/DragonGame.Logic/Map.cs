internal class Map
{
  #region constructor
  public Map()
  {
    _tiles = new Sprite[_mapTileSize.X, _mapTileSize.Y];
    List<Texture2D> textures = new(5);   // 5 different textureTiles
    for (int i = 1; i < 6; i++) textures.Add(Globals.Content.Load<Texture2D>($"tile{i}")); // tileNames

    TileSize = new(textures[0].Width, textures[0].Height);
    MapSize = new(TileSize.X * _mapTileSize.X, TileSize.Y * _mapTileSize.Y);

    Random random = new();

    for (int y = 0; y < _mapTileSize.Y; y++)
      for (int x = 0; x < _mapTileSize.X; x++)
      {
        int r = random.Next(0, textures.Count);
        _tiles[x, y] = new(textures[r], new(x * TileSize.X, y * TileSize.Y));
      }
  }
  #endregion constructor

  #region methods
  public void Draw()
  {
    for (int y = 0; y < _mapTileSize.Y; y++)
      for (int x = 0; x < _mapTileSize.X; x++)
        _tiles[x, y].Draw(); 
  }
  #endregion methods

  #region properties 
  public Point TileSize { get; private set; }
  public Point MapSize { get; private set; }
  #endregion properties 

  #region fields
  private readonly Point _mapTileSize = new(4, 3);
  private readonly Sprite[,] _tiles;
  #endregion fields
}