using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace BehindGodsCards.MyGame
{
    public static class GeneralFunctions
    {
        public static int ScreenWidth;
        public static int ScreenHeight;
        public static GameTime GameTime;
        public static GraphicsDeviceManager Graphics;
        public static ContentManager Content;
        public static SpriteBatch SpriteBatch;

        public static bool InMenu;
        public static bool InGame;

        public static int MouseX;
        public static int MouseY;
        public static ButtonState MouseLeftClicked;
        public static ButtonState MouseLRightClicked;

        public static double RelativeX;
        public static double RelativeSpeed;
        public static double RelativeMaxLeft;
        public static double RelativeMaxRight;

        
        public struct Fonts
        {
            public static Dictionary<string, SpriteFont> FontList = new Dictionary<string, SpriteFont>();
            public static void AddFont(string FontName)
            {
                FontList.Add(FontName, Content.Load<SpriteFont>(FontName));
            }
            public static SpriteFont Get(string FontName)
            {
                SpriteFont ToReturn = null;
                foreach(string Font in FontList.Keys)
                {
                    if(Font == FontName)
                    {
                        ToReturn = FontList[FontName];
                    }
                }
                if (ToReturn == null)
                {
                    ToReturn = FontList["Default"];
                }
                return ToReturn;
            }
        }

        
        public static void Init(SpriteBatch spritebatch, GraphicsDeviceManager graphics, ContentManager content)
        {
            SpriteBatch = spritebatch;
            Content = content;
            Graphics = graphics;
            InMenu = false;
            InGame = false;
            RelativeSpeed = 200;
        }

        public static void UpdateMouse()
        {
            MouseState mouse = Mouse.GetState();
            MouseX = mouse.Position.X;
            MouseY = mouse.Position.Y;
            MouseLeftClicked = mouse.LeftButton;
            MouseLRightClicked = mouse.RightButton;
        }
    }
}
