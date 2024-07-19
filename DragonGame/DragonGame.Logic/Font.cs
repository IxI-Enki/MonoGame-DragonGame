internal class Font
{
  #region methods
  internal static void Load(DragonGame dragonGame)
  {
    A14px
      = dragonGame.Content.Load
        <SpriteFont>("font14px");
    A16px
      = dragonGame.Content.Load
        <SpriteFont>("font16px");
    A18px
      = dragonGame.Content.Load
        <SpriteFont>("font18px");
    A20px
      = dragonGame.Content.Load
        <SpriteFont>("font20px");
    B14px
      = dragonGame.Content.Load
        <SpriteFont>("fontB14px");
    B16px
      = dragonGame.Content.Load
        <SpriteFont>("fontB16px");
    B18px
      = dragonGame.Content.Load
        <SpriteFont>("fontB18px");
    B20px
      = dragonGame.Content.Load
        <SpriteFont>("fontB20px");
    B30px
      = dragonGame.Content.Load
        <SpriteFont>("fontB30px");
  }
  #endregion  

  #region properties
  public static SpriteFont A14px { get; private set; }
  public static SpriteFont A16px { get; private set; }
  public static SpriteFont A18px { get; private set; }
  public static SpriteFont A20px { get; private set; }
  public static SpriteFont B14px { get; private set; }
  public static SpriteFont B16px { get; private set; }
  public static SpriteFont B18px { get; private set; }
  public static SpriteFont B20px { get; private set; }
  public static SpriteFont B30px { get; private set; }
  #endregion  
}