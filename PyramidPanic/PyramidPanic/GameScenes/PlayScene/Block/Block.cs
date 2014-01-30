// Met using kan je een XNA codebibliotheek toevoegen en gebruiken in je class
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
    //door : Image word de klasse block uit gevoerd door de klasse image
    public class Block : Image
    {
        //fields



        //constructor
        //hierdoor lomt het dat het object block gemaakt word
        public Block(PyramidPanic game, String pathNameAssert, Vector2 position)
            : base(game, pathNameAssert, position)
        {

        }
        //update



        //draw
        //dit zorgt er voor dat het bock op het scherm komt
        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
