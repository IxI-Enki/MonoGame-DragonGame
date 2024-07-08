namespace DragonGame.Logic
{
  public class DragonGame : Game
  {
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private SpriteFont 
      _font14px,
      _font16px,
      _font18px,
      _font20px,
      _fontB30px;

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
      _font16px = Content.Load<SpriteFont>("font16px");
      _font18px = Content.Load<SpriteFont>("font18px");
      _font20px = Content.Load<SpriteFont>("font20px");
      _fontB30px = Content.Load<SpriteFont>("fontB30px");
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
      _spriteBatch.DrawString(_font14px,  "[FONT-A px 14]", new Vector2(10, 10), Color.Yellow);
      _spriteBatch.DrawString(_font16px,  "[FONT-A px 16]", new Vector2(10, 24), Color.Orange);
      _spriteBatch.DrawString(_font18px,  "[FONT-A px 18]", new Vector2(10, 40), Color.DarkOrange);
      _spriteBatch.DrawString(_font20px,  "[FONT-A px 20]", new Vector2(10, 60), Color.OrangeRed);
      _spriteBatch.DrawString(_fontB30px, "[FONT-B px 30]", new Vector2(10, 90), Color.Green);
      _spriteBatch.DrawString(_fontB30px, "Font-test", new Vector2(10, 120), Color.LightGreen);
      _spriteBatch.End();


      base.Draw(gameTime);
    }
  }
}
