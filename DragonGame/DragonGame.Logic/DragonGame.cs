public class DragonGame : Game
{
  private GraphicsDeviceManager _graphics;
  private SpriteBatch _spriteBatch;

  private WindowManager _windowManager;
  private TileManager _tileManager;

  private GameWindow _window;

  private Hero _hero
    = new();

  public DragonGame()
  {
    _graphics = new(this);
    Content.RootDirectory = "Content";
    IsMouseVisible = true;
    _window = Window;
  }

  protected override void Initialize()
  {
    _windowManager = new(ref _window, ref _graphics);
    base.Initialize();
  }

  protected override void LoadContent()
  {
    _spriteBatch = new(GraphicsDevice);
    Font.Load(this);

    TextureManager.Load(this);
    _tileManager = new();
  }

  protected override void Update(GameTime gameTime)
  {
    if (Keyboard.GetState().IsKeyDown(Keys.Escape)) Exit();

    if (Keyboard.GetState().IsKeyDown(Keys.Up))
      _hero.entity.Position
        = new Vector2(
          _hero.entity.Position.X,
          _hero.entity.Position.Y - 10);
    if (Keyboard.GetState().IsKeyDown(Keys.Down))
      _hero.entity.Position
        = new Vector2(
          _hero.entity.Position.X,
          _hero.entity.Position.Y + 10);
    if (Keyboard.GetState().IsKeyDown(Keys.Left))
      _hero.entity.Position
        = new Vector2(
          _hero.entity.Position.X - 10,
          _hero.entity.Position.Y);
    if (Keyboard.GetState().IsKeyDown(Keys.Right))
      _hero.entity.Position
        = new Vector2(
          _hero.entity.Position.X + 10,
          _hero.entity.Position.Y);


    if (Keyboard.GetState().IsKeyDown(Keys.F11)) _windowManager.ToggleBorderless();

    base.Update(gameTime);
  }

  protected override void Draw(GameTime gameTime)
  {
    GraphicsDevice.Clear(Color.Black);

    // USE THIS TO SAMPLE PIXEL PERFECT
    _spriteBatch.Begin(samplerState: SamplerState.PointClamp);

    /*
    _spriteBatch.DrawString(Font.A14px, "[ FONT-A px 14 ]", new Vector2(10, 10), Color.Yellow);
    _spriteBatch.DrawString(Font.A16px, "[ FONT-A px 16 ]", new Vector2(10, 24), Color.Orange);
    _spriteBatch.DrawString(Font.A18px, "[ FONT-A px 18 ]", new Vector2(10, 40), Color.DarkOrange);
    _spriteBatch.DrawString(Font.A20px, "[ FONT-A px 20 ]", new Vector2(10, 60), Color.OrangeRed);
    _spriteBatch.DrawString(Font.B30px, "[ FONT-B px 30 ]", new Vector2(10, 90), Color.Green);
    _spriteBatch.DrawString(Font.B30px, "Font-test "
      //─━│┃┄┅┆┇┈┉┊┋┌┍┎┏┐┑┒┓└┕┖┗┘┙┚┛├┝┞┟┠┡┢┣┤┥┦┧┨┩┪┫┬┭┮┯┰┱┲┳┴┵┶┷┸┹┺┻┼┽┾┿╀╁╂╃╄╅╆╇╈╉╊╋╌╍╎╏═║╒╓╔╕╖╗╘╙╚╛╜╝╞╟╠╡╢╣╤╥╦╧╨╩╪╫╬╭╮╯╰╱╲╳╴╵╶╷╸╹╺╻╼╽╾╿
      , new Vector2(10, 120), Color.LightGreen);
    _spriteBatch.DrawString(Font.B20px, "[ FONT-B px 20 ] ┌┍┎┏┐┑┒┓└┕┖┗┘┙┚┛", new Vector2(10, 140), Color.OrangeRed);
    _spriteBatch.DrawString(Font.B18px, "[ FONT-B px 18 ] ┌┍┎┏┐┑┒┓└┕┖┗┘┙┚┛", new Vector2(10, 158), Color.OrangeRed);
    _spriteBatch.DrawString(Font.B16px, "[ FONT-B px 16 ] ┌┍┎┏┐┑┒┓└┕┖┗┘┙┚┛", new Vector2(10, 174), Color.OrangeRed);
    _spriteBatch.DrawString(Font.B14px, "[ FONT-B px 14 ] ┌┍┎┏┐┑┒┓└┕┖┗┘┙┚┛", new Vector2(10, 188), Color.OrangeRed);
    */
    _spriteBatch.DrawString(Font.B30px,
      "\n┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓" +
      "\n┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛",
      new Vector2(_window.ClientBounds.Width / 3, 158),
      Color.OrangeRed);

    _spriteBatch.DrawString(Font.B30px, _hero.entity.Sprite.ToString(), _hero.entity.Position, Color.Red);


    _spriteBatch.Draw(TextureManager.Textures[0], new Rectangle(10, 10, 64, 192), Color.White);
    _spriteBatch.End();

    base.Draw(gameTime);
  }
}