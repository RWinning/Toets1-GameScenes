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
    public class StartScene : IState //de class startScene implementeerd de interface IState.
    {
        //Fields
        private PyramidPanic game;

        //Maakt een variabelen (Reference) van Image class genaamt background
        private Image background;
        private Image title;

        public StartScene(PyramidPanic game)
        {
            this.game = game;
            // roept de Intialize method aan
            this.Intialize();
        }

        public void Intialize()
        {
            //Roept de LoadContant method aan
            this.LoadContent();
        }

        public void LoadContent()
        {
            //Nu maken we een object aan of instantie van de class image.
            this.background = new Image(this.game, @"StartScene\Background", new Vector2(0f ,0f));
            this.title = new Image(this.game, @"StartScene\Title", new Vector2(100f, 30f));
        }

        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.Right) || Input.EdgeDetectMousePressLeft())
            {
                this.game.IState = this.game.GameOverScene;
            }

            if (Input.EdgeDetectKeyDown(Keys.Left) || Input.EdgeDetectMousePressRight())
            {
                this.game.IState = this.game.HelpScene;
            }

        }

        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.Yellow);
            this.background.Draw(gameTime);
            this.title.Draw(gameTime);
            
            
        }
    }
}
