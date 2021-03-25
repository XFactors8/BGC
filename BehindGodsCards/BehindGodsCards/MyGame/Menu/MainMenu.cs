using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using BehindGodsCards.MyGame;

namespace BehindGodsCards.Menu
{
    public class MainMenu
    {
        
        public int WindowHeight;
        public int WindowWidth;

        protected Vector2 BackGroundPosition;
        protected Vector2 TitrePosition;
        protected Vector2 YnovLogoPosition;

        protected Texture2D BackGroundTexture;
        protected Texture2D TitreTexture;
        protected Texture2D YnovLogoTexture;

        List<MenuButtons> Boutons = new List<MenuButtons>();

        public MainMenu()
        {
            WindowHeight = GeneralFunctions.ScreenHeight;
            WindowWidth = GeneralFunctions.ScreenWidth;
        }

        public void Load()
        {
            BackGroundTexture = GeneralFunctions.Content.Load<Texture2D>("MenuContent\\" + "bgBGC");
            TitreTexture = GeneralFunctions.Content.Load<Texture2D>("MenuContent\\" + "titremenu");
            YnovLogoTexture = GeneralFunctions.Content.Load<Texture2D>("MenuContent\\" + "YnovLogo");

            Boutons.Add(new MenuButtons("play_sprite_1", "play_sprite_2", "play_sprite_3", "Play"));
            Boutons.Add(new MenuButtons("option_sprite_1", "option_sprite_2", "option_sprite_3", "Options"));
            Boutons.Add(new MenuButtons("credits_sprite_1", "credits_sprite_2", "credits_sprite_3", "Credits"));
            Boutons.Add(new MenuButtons("quit_sprite_1", "quit_sprite_2", "quit_sprite_3", "Quit"));

            BackGroundPosition = new Vector2(0, 0);
            TitrePosition = new Vector2((WindowWidth - TitreTexture.Width) / 2, TitreTexture.Height / 6);
            YnovLogoPosition = new Vector2(-10, WindowHeight - YnovLogoTexture.Height + 10);

            int ButtonSpace = TitreTexture.Height / 6;
            for (int i = 0; i < Boutons.Count; i++)
            {
                Boutons[i].ButtonsPosition.X = (WindowWidth - Boutons[i].Sprite1.Width) / 2;
                Boutons[i].ButtonsPosition.Y = TitreTexture.Height + i * (Boutons[0].Sprite1.Height + ButtonSpace);
            }
        }
        public string Update()
        {
            string ToReturn = "";
            foreach (MenuButtons bouton in Boutons)
            {
                if (bouton.Clicked == true && GeneralFunctions.MouseLeftClicked == ButtonState.Released)
                {
                    switch (bouton.Name)
                    {
                        case "Play":
                            foreach (MenuButtons btn in Boutons)
                            {
                                btn.Selected = false;
                                btn.Clicked = false;
                            }
                            ToReturn = "Play";
                            break;
                        case "Options":
                            foreach (MenuButtons btn in Boutons)
                            {
                                btn.Selected = false;
                                btn.Clicked = false;
                            }
                            ToReturn = "Options";
                            break;
                        case "Credits":
                            foreach (MenuButtons btn in Boutons)
                            {
                                btn.Selected = false;
                                btn.Clicked = false;
                            }
                            ToReturn = "Credits";
                            break;
                        case "Quit":
                            ToReturn = "Quit";
                            break;
                    }
                }
                bouton.Update();
            }
            return ToReturn;
        }
        public void Draw()
        {

            GeneralFunctions.SpriteBatch.Draw(BackGroundTexture, BackGroundPosition, Color.White);
            GeneralFunctions.SpriteBatch.Draw(TitreTexture, TitrePosition, Color.White);
            GeneralFunctions.SpriteBatch.Draw(YnovLogoTexture, YnovLogoPosition, Color.White);

            foreach (MenuButtons Button in Boutons)
            {
                Button.Draw();
            }

        }
    }
}