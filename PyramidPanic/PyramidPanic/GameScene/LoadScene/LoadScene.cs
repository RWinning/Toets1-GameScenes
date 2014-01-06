﻿// Met using kan je een XNA codebibliotheek toevoegen en gebruiken in je class
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
    public class LoadScene : IState
    {
        //Fields
        private PyramidPanic game;

         public LoadScene(PyramidPanic game)
        {
            this.game = game;
        }

        public void Intialize()
        {


        }

        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.B))
            {
                this.game.IState = this.game.StartScene;
            }

            if (Input.EdgeDetectKeyDown(Keys.Left) || Input.EdgeDetectMousePressRight())
            {
                this.game.IState = this.game.GameOverScene;
            }
        }

        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.NavajoWhite);
        }
    }
}
