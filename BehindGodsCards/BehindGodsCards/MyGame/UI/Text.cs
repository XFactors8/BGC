using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace BehindGodsCards.MyGame
{
    public class Texts
    {
        public Vector2 Position;
        public SpriteFont Font;
        public string Text;
        public bool Hidden;

        public Texts(string font, string text)
        {
            Font = GeneralFunctions.Fonts.Get(font);
            Text = text;
            Hidden = true;
        }
        public Texts(string font, string text, int X, int Y)
        {
            Font = GeneralFunctions.Fonts.Get(font);
            Text = text;
            Position = new Vector2(X, Y);
        }

        public void Draw(Vector2 Position)
        {
            GeneralFunctions.SpriteBatch.DrawString(Font, Text, Position, Color.Black);
        }
    }
}

