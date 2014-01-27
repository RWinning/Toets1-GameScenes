using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
   public class TestScene 
    {
       //fields

       private PyramidPanic game;

       public TestScene(PyramidPanic game)
       {
           this.game = game;
       }

       //update method

       //draw method
       public void Draw(GameTime gameTime)
       {
           this.game.GraphicsDevice.Clear(Color.Yellow);
       }
       
      
    }
}
