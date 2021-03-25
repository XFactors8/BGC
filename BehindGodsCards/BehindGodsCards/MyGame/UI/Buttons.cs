using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BehindGodsCards.MyGame
{
    public class Buttons
    {
        public string Name;
        public Vector2 Position;

        public Texture2D Sprite = null;
        public Texture2D SpriteSelected = null;
        public Texture2D SpriteClicked = null;
        public Texture2D SpriteSelectedClicked = null;

        public bool Selected;
        public bool Clicked;
        public bool Stayclicked;

        public Buttons(string name, string texture, string textureSelected, string textureClicked)
        {
            Sprite = GeneralFunctions.Content.Load<Texture2D>(texture);
            SpriteSelected = GeneralFunctions.Content.Load<Texture2D>(textureSelected);
            SpriteClicked = GeneralFunctions.Content.Load<Texture2D>(textureClicked);

            Name = name;
        }

        public Buttons(string name, string texture, string textureSelected, string textureClicked, int X, int Y)
        {
            Sprite = GeneralFunctions.Content.Load<Texture2D>(texture);
            SpriteSelected = GeneralFunctions.Content.Load<Texture2D>(textureSelected);
            SpriteClicked = GeneralFunctions.Content.Load<Texture2D>(textureClicked);
            Name = name;
            Position = new Vector2(X, Y);
        }
        public Buttons(string name, string texture, string textureSelected, string textureClicked, string textureSelectedClicked)
        {
            Sprite = GeneralFunctions.Content.Load<Texture2D>(texture);
            SpriteSelected = GeneralFunctions.Content.Load<Texture2D>(textureSelected);
            SpriteClicked = GeneralFunctions.Content.Load<Texture2D>(textureClicked);
            SpriteSelectedClicked = GeneralFunctions.Content.Load<Texture2D>(textureSelectedClicked);
            Name = name;
            //Position = new Vector2(X, Y);
        }

        public string Update(Vector2 DivPosition)
        {
            //Actualiser les boutons
            if (GeneralFunctions.MouseX > Position.X + DivPosition.X && GeneralFunctions.MouseX < Position.X + DivPosition.X + Sprite.Width && GeneralFunctions.MouseY > Position.Y + DivPosition.Y && GeneralFunctions.MouseY < Position.Y + Sprite.Height + DivPosition.Y)
            {
                Selected = true;
            }
            else
            {
                Selected = false;
            }
            System.Diagnostics.Debug.WriteLine(Selected);
            if (Selected && GeneralFunctions.MouseLeftClicked == ButtonState.Pressed)
            {
                System.Diagnostics.Debug.WriteLine("here");
                Clicked = true;
                return Name;
            }
            return "None";
        }

        public void Draw(Vector2 DivPosition)
        {
            Texture2D ToDraw = Sprite;

            if (SpriteSelectedClicked == null)
            {
                if (Selected)
                {
                    ToDraw = SpriteSelected;
                    if (Clicked)
                    {
                        ToDraw = SpriteClicked;
                    }
                }
            }
            else
            {
                if (Selected)
                {
                    ToDraw = SpriteSelected;
                    if (Clicked)
                    {
                        ToDraw = SpriteSelectedClicked;
                    }
                }
                else
                {
                    if (Clicked)
                    {
                        ToDraw = SpriteClicked;
                    }
                }
            }
            GeneralFunctions.SpriteBatch.Draw(ToDraw, new Vector2 (DivPosition.X + Position.X, DivPosition.Y + Position.Y) , Color.White);
        }
    }
}
