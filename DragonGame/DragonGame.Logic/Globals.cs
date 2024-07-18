﻿using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonGame.Logic;
public static class Globals
{
  public static float Time { get; set; }
  public static ContentManager Content { get; set; }
  public static SpriteBatch SpriteBatch { get; set; }

  public static Point WindowSize { get; set; }
  public static void Update(GameTime gameTime) { Time = (float)gameTime.TotalGameTime.TotalSeconds; }
}

