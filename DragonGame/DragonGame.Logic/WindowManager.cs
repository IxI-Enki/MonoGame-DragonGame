internal class WindowManager
{
  public WindowManager(ref GameWindow window, ref GraphicsDeviceManager graphics)
  {
    _window = window;
    _window.Title = "Drachen-Game";
    _window.AllowUserResizing = true;
    _graphics = graphics;
  }

  public void ToggleFullscreen()
  {
    bool oldIsFullscreen = _isFullscreen;

    if (_isBorderless) _isBorderless = false;
    else _isFullscreen = !_isFullscreen;

    ApplyFullscreenChange(oldIsFullscreen);
  }

  public void ToggleBorderless()
  {
    bool oldIsFullscreen = _isFullscreen;

    _isBorderless = !_isBorderless;
    _isFullscreen = _isBorderless;

    ApplyFullscreenChange(oldIsFullscreen);
  }

  private void ApplyFullscreenChange(bool oldIsFullscreen)
  {
    if (_isFullscreen)
    {
      if (oldIsFullscreen) ApplyHardwareMode();
      else SetFullscreen();
    }
    else UnsetFullscreen();
  }

  private void ApplyHardwareMode()
  {
    _graphics.HardwareModeSwitch = !_isBorderless;
    _graphics.ApplyChanges();
  }

  private void SetFullscreen()
  {
    _width = _window.ClientBounds.Width;
    _height = _window.ClientBounds.Height;

    _graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
    _graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
    _graphics.HardwareModeSwitch = !_isBorderless;

    _graphics.IsFullScreen = true;
    _graphics.ApplyChanges();
  }

  private void UnsetFullscreen()
  {
    _graphics.PreferredBackBufferWidth = _width;
    _graphics.PreferredBackBufferHeight = _height;
    _graphics.IsFullScreen = false;
    _graphics.ApplyChanges();
  }

  private bool
    _isFullscreen = false,
    _isBorderless = false;
  private int
    _height = 0,
    _width = 0;
  private GameWindow
    _window;
  private GraphicsDeviceManager
    _graphics;
}