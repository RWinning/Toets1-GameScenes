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

    public class PyramidPanic : Microsoft.Xna.Framework.Game
    {
        //Fields
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        
        

        //Maak een variable aan van het type StartScene
        private StartScene startScene;

        //Maak een variable aan van het type PlayScene
        private PlayScene playScene;

        //Maak een variable aan van het type LoadScene
        private LoadScene loadScene;

        //Maak een variable aan van het type HelpScene
        private HelpScene helpScene;

        //Maak een variable aan van het type ScoresScene
        private ScoresScene scoresScene;

        //Maak een variable aan van het type GameOverScene
        private GameOverScene gameOverScene;

        //Maak een variable aan van het type QuitScene
        private QuitScene quitScene;

        //maak een variable ISate aan met type interface.
        private IState iState;



        #region Proberties
        //proberties
        //maak de interface variable iState beschikbaar buiten de class d.m.v. 
        //een propertie IState
        public IState IState
        {
            get { return this.iState; }
            set { this.iState = value; }

        }

        //maak het field this.startScene beschikbaar buiten de class d.m.v
        //een propertie StartScene
        public StartScene StartScene
        {
            get { return this.startScene; }
        }

        //maak het field this.playScene beschikbaar buiten de class d.m.v
        //een propertie PlayScene
        public PlayScene PlayScene
        {
            get { return this.playScene; }
        }


        //maak het field this.loadScene beschikbaar buiten de class d.m.v
        //een propertie LoadScene
        public LoadScene LoadScene
        {
            get { return this.loadScene; }
        }

        //maak het field this.helpScene beschikbaar buiten de class d.m.v
        //een propertie HelpScene
        public HelpScene HelpScene
        {
            get { return this.helpScene; }
        }

        //maak het field this.helpScene beschikbaar buiten de class d.m.v
        //een propertie HelpScene
        public ScoresScene ScoresScene
        {
            get { return this.scoresScene; }
        }

        //maak het field this.gameOverScene beschikbaar buiten de class d.m.v
        //een propertie GameOverScene
        public GameOverScene GameOverScene
        {
            get { return this.gameOverScene; }
        }

        //maak het field this.quitScene beschikbaar buiten de class d.m.v
        //een propertie QuitScene
        public QuitScene QuitScene
        {
            get { return this.quitScene; }
        }

        //maak het field this.spriteBatch beschikbaar buiten de class d.m.v
        //een propertie SpriteBatch
        public SpriteBatch SpriteBatch
        {
            get { return this.spriteBatch; }
        }
        
        #endregion
        //Dit is de constructor. Heeft altijd dezelfde naam als de class.
        public PyramidPanic()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // Verander de titel van het canvas
            Window.Title = "Pyramid Panic Beta 00.00.00.01";

            // Maakt de muis zichtbaar
            IsMouseVisible = true;

            // Verandert de breedte van het canvas.
            this.graphics.PreferredBackBufferWidth = 640;

            // Verandert de hoogte van het canvas.
            this.graphics.PreferredBackBufferHeight = 480;

            // Past de nieuwe hoogte en breedte toe.
            this.graphics.ApplyChanges();

            this.iState = this.gameOverScene;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Een spritebatch is nodig voor het tekenen van textures op het canvas
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            //We maken nu het object/instalatie aan van het type Startscene. Dit doe je door
            //de constructor aan te roepen van de Startscene class.
            this.startScene = new StartScene(this);

            //Nieuwe instantie van de PlayScene class
            this.playScene = new PlayScene(this);

            //Nieuwe instantie van de LoadScene class
            this.loadScene = new LoadScene(this);

            //Nieuwe instantie van de HelpScene class
            this.helpScene = new HelpScene(this);

            //Nieuwe instantie van de ScoresScene class
            this.scoresScene = new ScoresScene(this);

            //Nieuwe instantie van de GameOverScene class
            this.gameOverScene = new GameOverScene(this);

            //Nieuwe instantie van de QuitScene class
            this.quitScene = new QuitScene(this);



           

            this.iState = this.startScene;
        }
        
        protected override void UnloadContent()
        {

        }


        protected override void Update(GameTime gameTime)
        {
            // Zorgt dat het spel stopt wanneer je op de gamepad button Back indrukt
            if ((GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed) ||
                (Keyboard.GetState().IsKeyDown(Keys.Escape)))
                this.Exit();
            //De update method van de static Input class wordt aangeroepen
            Input.Update();

            //De update methode van het object die toegewesen is aan het interface object
            //this.IState word aan geroepen.
            this.iState.Update(gameTime);

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            //Geeft de achtergrond een kleur
            GraphicsDevice.Clear(Color.Black);
            

            //Voor een spriteBatch iets kan tekenen moet Begin() method
            //aangeroepen worden van de SpriteBatch class.
            this.spriteBatch.Begin();

            //De draw methode van het object die toegewesen is aan het interface object
            //this.IState word aan geroepen.
            this.iState.Draw(gameTime);

            //Nadat de spriteBatch.Draw() is aangeroepen moet End() method van de
            //SpriteBatch class worden aangeroepen.
            this.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}