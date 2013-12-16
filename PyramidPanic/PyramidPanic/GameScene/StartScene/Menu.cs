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


        private Color activeColor = Color.Gold;

        // maak een enumiration voor de mogelijke buttons.
        private enum Buttons { Start, Load, Help, Scores, Quit };


        //maak een variable van het type buttons en geef hem de waarde.Start.
        private Buttons buttonActive = Buttons.Start;

        //maak een variable van het type Buttons en geef hem de waarde.Start.
        private List<Image> ButtonList;


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
            this.ButtonList = new List<Image>();
            this.ButtonList.Add(this.Start = new Image(this.game, @"StartScene\Button_start", new Vector2(10f, 430f)));
            this.ButtonList.Add(this.Load = new Image(this.game, @"StartScene\Button_load", new Vector2(140f, 430f)));
            this.ButtonList.Add(this.Help = new Image(this.game, @"StartScene\Button_help", new Vector2(270f, 430f)));
            this.ButtonList.Add(this.Scores = new Image(this.game, @"StartScene\Button_scores", new Vector2(400f, 430f)));
            this.ButtonList.Add(this.Quit = new Image(this.game, @"StartScene\Button_quit", new Vector2(530f, 430f)));
        }


        //Update
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.Right))
            {
                this.ChangeButtonColorToNormal();
                this.buttonActive++;
            }

            if (Input.EdgeDetectKeyDown(Keys.Left))
            {
                this.ChangeButtonColorToNormal();
                this.buttonActive--;
            }

           

            //maak een switchcase instructie voor de variable voor buttonActive
            switch (this.buttonActive)
            {
                case Buttons.Start:
                    this.Start.Color = this.activeColor;
                    if (Input.EdgeDetectKeyDown(Keys.Enter))
                    {
                        this.game.IState = this.game.PlayScene;
                    }
                    break;
                case Buttons.Load:
                    this.Load.Color = this.activeColor;
                    if (Input.EdgeDetectKeyDown(Keys.Enter))
                    {
                        this.game.IState = this.game.PlayScene;
                    }
                    break;            
                case Buttons.Help:
                    this.Help.Color = this.activeColor;
                    if (Input.EdgeDetectKeyDown(Keys.Enter))
                    {
                        this.game.IState = this.game.HelpScene;
                    }
                    break;            
                case Buttons.Scores:
                    this.Scores.Color = this.activeColor;
                    if (Input.EdgeDetectKeyDown(Keys.Enter))
                    {
                        this.game.IState = this.game.PlayScene;
                    }
                    break;           
                case Buttons.Quit:
                    this.Quit.Color = this.activeColor;
                    if (Input.EdgeDetectKeyDown(Keys.Enter))
                    {
                        game.Exit();
                    }
                    break;
            }
        }


        //Draw
        public void Draw(GameTime gameTime)
        {
            foreach (Image image in this.ButtonList)
            {
                image.Draw(gameTime);
            }
        }
        //helper method voor het met wit licht beschijnen van de buttons.
        private void ChangeButtonColorToNormal()
        {
            //we doorlopen de list<image> this.buttonlist met een foreach instructor.

            foreach (Image image in this.ButtonList)
            {
                image.Color = Color.White;
            }
        }
    }
}
