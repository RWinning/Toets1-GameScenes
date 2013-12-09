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
    public class Menu
    {
        //Fields
        private Image Start;
        private Image Load;
        private Image Help;
        private Image Scores;
        private Image Quit;
        private PyramidPanic game;


        //Construcor
        public Menu(PyramidPanic game)
        {
            this.game = game;
            this.Initialize();
        }

        public void Initialize()
        {
            this.LoadContent();
        }


        public void LoadContent()
        {
            this.Start = new Image(this.game, @"StartScene\Button_start", new Vector2(10f, 430f));
            this.Load = new Image(this.game, @"StartScene\Button_load", new Vector2(140f, 430f));
            this.Help = new Image(this.game, @"StartScene\Button_help", new Vector2(270f, 430f));
            this.Scores = new Image(this.game, @"StartScene\Button_scores", new Vector2(400f, 430f));
            this.Quit = new Image(this.game, @"StartScene\Button_quit", new Vector2(530f, 430f));
        }


        //Update
        public void Update(GameTime gameTime)
        {

        }


        //Draw
        public void Draw(GameTime gameTime)
        {
            this.Start.Draw(gameTime);
            this.Load.Draw(gameTime);
            this.Help.Draw(gameTime);
            this.Scores.Draw(gameTime);
            this.Quit.Draw(gameTime);
        }
    }
}
