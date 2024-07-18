public class DragonGame : Game
{
  #region fields
  private GraphicsDeviceManager _graphics;
  private SpriteBatch _spriteBatch;
  //
  private WindowManager _windowManager;
  private TileManager _tileManager;
  private GameWindow _window;
  //
  private GameManager _gameManager;
  #endregion fields

  #region constructor
  public DragonGame()
  {
    _graphics = new(this);
    Content.RootDirectory = "Content";
    IsMouseVisible = true;
    _window = Window;
    _gameManager = new();
  }
  #endregion constructor

  #region overrides
  protected override void Initialize()
  {
    _windowManager = new(ref _window, ref _graphics);
    //
    base.Initialize();
  }

  protected override void LoadContent()
  {
    _spriteBatch = new(GraphicsDevice);
    //
    Font.Load(this);
    TextureManager.Load(this);
    //
    _tileManager = new();
  }

  protected override void Update(GameTime gameTime)
  {
    Globals.Update(gameTime);
    InputManager.Update();
    _gameManager.Update();
    //
    if (Keyboard.GetState().IsKeyDown(Keys.Escape)) Exit();
    if (Keyboard.GetState().IsKeyDown(Keys.F11)) _windowManager.ToggleBorderless();
    //
    base.Update(gameTime);
  }

  protected override void Draw(GameTime gameTime)
  {
    GraphicsDevice.Clear(Color.Black);
    //
    _gameManager.Draw();

    // USE THIS TO SAMPLE PIXEL PERFECT
    _spriteBatch.Begin(samplerState: SamplerState.PointClamp);
    _spriteBatch.End();
    //
    TextureManager.DrawCircle(96, new Vector2(30f, 30f), Color.White, _spriteBatch);
    TextureManager.DrawSquareGrid(_spriteBatch);
    //
    base.Draw(gameTime);
  }
  #endregion overrides
}

#region outdated
/*
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
    
    _spriteBatch.DrawString(Font.B30px, Hero.entity.Sprite.ToString(), Hero.entity.Position, Color.Red);
    _spriteBatch.Draw(TextureManager.Textures[0], new Rectangle(10, 10, 64, 192), Color.White);
    _spriteBatch.End();
    *
    *
    *
    *
    *
    if (Keyboard.GetState().IsKeyDown(Keys.Up))
      Hero.entity.Position
        = new Vector2(
          Hero.entity.Position.X,
          Hero.entity.Position.Y - 10);
    if (Keyboard.GetState().IsKeyDown(Keys.Down))
      Hero.entity.Position
        = new Vector2(
          Hero.entity.Position.X,
          Hero.entity.Position.Y + 10);
    if (Keyboard.GetState().IsKeyDown(Keys.Left))
      Hero.entity.Position
        = new Vector2(
          Hero.entity.Position.X - 10,
          Hero.entity.Position.Y);
    if (Keyboard.GetState().IsKeyDown(Keys.Right))
      Hero.entity.Position
        = new Vector2(
          Hero.entity.Position.X + 10,
          Hero.entity.Position.Y);
    */
#endregion outdated