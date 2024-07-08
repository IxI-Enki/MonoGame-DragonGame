namespace DragonGame.Logic
{
  public class DragonGame : Game
  {
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private SpriteFont _font14px;

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
      _spriteBatch = new(GraphicsDevice);
      _spriteBatch.Begin();
      _font14px = Content.Load<SpriteFont>("font14px");
      _spriteBatch.End();
    }

    protected override void Update(GameTime gameTime)
    {
      if (Keyboard.GetState().IsKeyDown(Keys.Escape)) Exit();
      base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
      GraphicsDevice.Clear(Color.Black);

      _spriteBatch.Begin();
      _spriteBatch.DrawString(_font14px, "Hello", new Vector2(10, 10), Color.White);
      _spriteBatch.End();


      base.Draw(gameTime);
    }
  }
}
