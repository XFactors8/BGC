using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using BehindGodsCards.MyGame;
using Microsoft.Xna.Framework.Audio;

namespace BehindGodsCards.Menu
{
    class MenuButtons
    {
        public Texture2D Sprite1;
        public Texture2D Sprite2;
        public Texture2D Sprite3;
        public SoundEffect SelectedSound;
        
        public Vector2 ButtonsPosition;

        public bool PlaySelected;
        public bool Selected;
        public bool Clicked;
        public string Name;

        public MenuButtons(string Name1, string Name2, string Name3, string NameGive)
        {
            Sprite1 = GeneralFunctions.Content.Load<Texture2D>("MenuContent\\" + Name1);
            Sprite2 = GeneralFunctions.Content.Load<Texture2D>("MenuContent\\" + Name2);
            Sprite3 = GeneralFunctions.Content.Load<Texture2D>("MenuContent\\" + Name3);
            SelectedSound = GeneralFunctions.Content.Load<SoundEffect>("MenuAudio\\SelectedSound");
            Name = NameGive;
        }
        public void Draw()
        {
            Texture2D toDraw = Sprite1;

            if (Selected)
            {
                toDraw = Sprite2;
                if (Clicked)
                {
                    toDraw = Sprite3;
                }
            }
            GeneralFunctions.SpriteBatch.Draw(toDraw, ButtonsPosition, Color.White);
        }

        public void Update()
        {
            if (Selected == true)
            {
                PlaySelected = false;
            } else
            {
                PlaySelected = true;
            }
            
            if (GeneralFunctions.MouseX >= ButtonsPosition.X && GeneralFunctions.MouseX <= ButtonsPosition.X + Sprite1.Width && GeneralFunctions.MouseY >= ButtonsPosition.Y && GeneralFunctions.MouseY <= ButtonsPosition.Y + Sprite1.Height)
            {
                Selected = true;
                if (PlaySelected == true)
                {
                    SelectedSound.Play(1.0f, 0.0f, 0.0f);
                }
            }
            else
            {
                Selected = false;
            }

            if (Selected && GeneralFunctions.MouseLeftClicked == ButtonState.Pressed)
            {
                Clicked = true;
            }
            else
            {
                Clicked = false;
            }
        }
    }
}
