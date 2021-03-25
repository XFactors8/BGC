using BehindGodsCards.Menu;
using BehindGodsCards.MyGame.Characters;
using BehindGodsCards.MyGame.Structures;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BehindGodsCards.MyGame
{
    public class GameManager
    {

        public struct gameState
        {
            public bool InMenu;
            public bool InGame;
        }

        public MainMenu Menu;
        public Map Map;
        public gameState GameState;
        public GameTime GameTime;
        public bool Pause;
        public string Response;
        public Players PlayerOne;
        public Players PlayerTwo;
        public HUD Hud;

        public GameManager(ContentManager Content, GraphicsDeviceManager Graphics, SpriteBatch SpriteBatch)
        {
            GameState = new gameState();
            Menu = new MainMenu();
            Map = new Map(Content, SpriteBatch);
            GeneralFunctions.Init(SpriteBatch, Graphics, Content);
            Hud = new HUD();
        }
        public void Initialise()
        {
            Menu.Load();
            GeneralFunctions.InMenu = true;
            GeneralFunctions.InGame = false;
        }

        public void Update(GameTime GameTime)
        {
            GeneralFunctions.UpdateMouse();
            GeneralFunctions.GameTime = GameTime;

            if (GeneralFunctions.InMenu)
            {
                Response = Menu.Update();
                switch (Response)
                {
                    case "Play":
                        LoadGame();
                        GeneralFunctions.InMenu = false;
                        GeneralFunctions.InGame = true;
                        break;
                    case "Options":
                        break;
                    case "Credits":
                        break;
                    case "Quit":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
            if (GeneralFunctions.InGame)
            {
                Map.Update();
                PlayerOne.Update();
                Hud.Update();
            }
        }
        public void Draw()
        {
            if (GeneralFunctions.InMenu)
            {
                Menu.Draw();
            }
            if (GeneralFunctions.InGame)
            {
                Map.Draw();
                PlayerOne.Draw();
                Hud.Draw();
            }
        }


        public void LoadGame()
        {
            PlayerOne = new Players();
            PlayerOne.AddUnit("Cac");
            PlayerTwo = new Players();
            HUD Hud = new HUD();
        }
    }
}
