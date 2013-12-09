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
    public class Image
    {
        //FieldsMethod
        private Texture2D texture;

        //maak een variable aan om de game insantie op te slaan.
        private PyramidPanic game;
        
        //Maak een rectengle voor het deselecteren van collision
        private Rectangle rectangle;

        //ConstructorMethod
        public Image(PyramidPanic game, string pathNameAsset, Vector2 position)
        {
            this.texture = game.Content.Load<Texture2D>(pathNameAsset);
            this.rectangle = new Rectangle((int)position.X, (int)position.Y, this.texture.Width, this.texture.Height); 
        }

        //UpdateMethod

        //DrawMethod
        public void Draw(GameTime gameTime)
        {
            this.game.SpriteBatch.Draw(this.texture, this.rectangle, Color.White);
            
        }


        //HelperMethod
    }
}
