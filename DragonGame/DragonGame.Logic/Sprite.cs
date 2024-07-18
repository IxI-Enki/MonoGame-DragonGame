public class Sprite(Texture2D texture, Vector2 position)
{
    #region methods
    public void Draw()
    {
        Globals.SpriteBatch.Draw(_texture, Position, null, Color.White, 0f, Origin, 1f, SpriteEffects.None, 0f);
    }
    #endregion methods

    #region properties
    public Vector2 Position { get; protected set; } = position;
    public Vector2 Origin { get; protected set; } = new(texture.Width / 2, texture.Height / 2);
    #endregion properties

    #region fields
    private readonly Texture2D _texture = texture;
    #endregion fields
}