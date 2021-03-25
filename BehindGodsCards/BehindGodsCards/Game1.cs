using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using BehindGodsCards.MyGame;
using BehindGodsCards.Menu;

//System.Diagnostics.Debug.WriteLine("");


namespace BehindGodsCards
{
    
    public class Game1 : Game
    {
        public GraphicsDeviceManager _graphics;
        public SpriteBatch _spriteBatch;
        public GameManager GameManager;
        

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 1200;
            _graphics.PreferredBackBufferHeight = 560;
            GeneralFunctions.ScreenWidth = _graphics.PreferredBackBufferWidth;
            GeneralFunctions.ScreenHeight = _graphics.PreferredBackBufferHeight;
            _graphics.ApplyChanges();
            GeneralFunctions.Content = Content;
            GeneralFunctions.SpriteBatch = _spriteBatch;
            base.Initialize();
        }
        
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            GameManager = new GameManager(Content, _graphics, _spriteBatch);
            GameManager.Initialise();

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }
            GameManager.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();

            GraphicsDevice.Clear(Color.Black);
            GameManager.Draw();
            
            _spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}
