namespace DragonGame.Logic
{
  public class DragonGame : Game
  {
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public DragonGame()
    {
      _graphics = new(this);
      Content.RootDirectory = "Content";
      IsMouseVisible = true;
    }

    protected override void Initialize()
    {
      base.Initialize();
    }

    protected override void LoadContent()
    {
      _spriteBatch = new SpriteBatch(GraphicsDevice);
    }

    protected override void Update(GameTime gameTime)
    {
      if (Keyboard.GetState().IsKeyDown(Keys.Escape)) Exit();
      base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
      GraphicsDevice.Clear(Color.Black);
      base.Draw(gameTime);
    }
  }
}
