using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;


namespace BehindGodsCards.MyGame
{
    public class Map
    {

        public struct FX
        {
            public List<Texture2D> Sprites;
            public Vector2 Position;
            public int SpriteState;
            public float Tick;
            public float TickUpdate;
            public void NewSprite(ContentManager Content,  string ContentPath)
            {
                Content.Load<Texture2D>(ContentPath);
            }
        }

        public Texture2D Background;
        public Vector2 BackgroundPosition;

        public List<FX> BackgroundFX;
        public ContentManager Content;
        SpriteBatch SpriteBatch;

        public Map(ContentManager content, SpriteBatch spritebatch)
        {
            Content = content;
            SpriteBatch = spritebatch;
            Background = content.Load<Texture2D>("GameContent\\" + "MapBackground");
            GeneralFunctions.RelativeMaxLeft = 0;
            GeneralFunctions.RelativeMaxRight = GeneralFunctions.ScreenWidth - Background.Width;
        }

        public void Update()
        {
            
            KeyboardState KeyboardState = Keyboard.GetState();

            if (KeyboardState.IsKeyDown(Keys.Q))
            {
                GeneralFunctions.RelativeX += GeneralFunctions.RelativeSpeed / GeneralFunctions.GameTime.ElapsedGameTime.TotalMilliseconds;
                if (GeneralFunctions.RelativeX >= GeneralFunctions.RelativeMaxLeft)
                {
                    GeneralFunctions.RelativeX = GeneralFunctions.RelativeMaxLeft;
                }
            }
            if (KeyboardState.IsKeyDown(Keys.D))
            {
                GeneralFunctions.RelativeX -= GeneralFunctions.RelativeSpeed / GeneralFunctions.GameTime.ElapsedGameTime.TotalMilliseconds;
                if (GeneralFunctions.RelativeX <= GeneralFunctions.RelativeMaxRight)
                {
                    GeneralFunctions.RelativeX = GeneralFunctions.RelativeMaxRight;
                }
            }
        }
        public void Draw()
        {
            SpriteBatch.Draw(Background, new Vector2(0 + Convert.ToSingle(GeneralFunctions.RelativeX), 0), Color.White);
        }
    }
}
