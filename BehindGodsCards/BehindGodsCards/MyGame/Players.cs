using System;
using System.Collections.Generic;
using System.Text;
using BehindGodsCards.MyGame.Structures;
using BehindGodsCards.MyGame.Characters;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BehindGodsCards.MyGame
{
    public class Players
    {
        
        public List<Units> Characters = new List<Units>();
        public int Money;
        public int MaxMoney;
        public int MaxUnit;
        public int Farmer;
        public bool IsBot;
        public string PlayerName;
        public HQ Base;

        public Players()
        {
            Base = new HQ();
            Money = 100;
            MaxMoney = 10000;
            MaxUnit = 10;
            Farmer = 0;
        }

        public bool AddMoney(int ValueToAdd)
        {
            Money += ValueToAdd;
            if(Money > MaxMoney)
            {
                Money = MaxMoney;
                return false;
            }
            return true;
        }

        public bool UseMoney(int ValueToRemove)
        {   
            if (Money >= ValueToRemove)
            {
                Money -= ValueToRemove;
                return true;
            }
            return false;
        }

        public void AddUnit(string UnitName)
        {
            Characters.Add(new Cac(Base.Barracks.Lvl));
            //Characters.Add(new BehindGodsCards.MyGame.Characters.Range(Base.Barracks.Lvl));
            //Characters.Add(new Tank(Base.Barracks.Lvl));
            //Characters.Add(new AntiTank(Base.Barracks.Lvl));
        }
        public void Update()
        {
            if(Characters.Count >= 0)
            {
                foreach(Units Character in Characters)
                {
                    Character.Update();
                }
            }
        }
        
        public void Draw()
        {
            Base.Draw();
            if(Characters.Count > 0)
            {
                foreach(Units Character in Characters)
                {
                    foreach(Animation Animation in Character.Animations)
                    {
                        if(Animation.Name == "Walk")
                        {
                            GeneralFunctions.SpriteBatch.Draw(Animation.Textures[Animation.TextureNumber], new Vector2(50 + Convert.ToSingle(GeneralFunctions.RelativeX), 50), Color.White);
                        }
                        if (Animation.Name == "Idle")
                        {
                            GeneralFunctions.SpriteBatch.Draw(Animation.Textures[Animation.TextureNumber], new Vector2(50 + Convert.ToSingle(GeneralFunctions.RelativeX), 150), Color.White);
                        }
                        if (Animation.Name == "Attack")
                        {
                            GeneralFunctions.SpriteBatch.Draw(Animation.Textures[Animation.TextureNumber], new Vector2(50 + Convert.ToSingle(GeneralFunctions.RelativeX), 300), Color.White);
                        }
                        if (Animation.Name == "Kick")
                        {
                            GeneralFunctions.SpriteBatch.Draw(Animation.Textures[Animation.TextureNumber], new Vector2(50 + Convert.ToSingle(GeneralFunctions.RelativeX), 450), Color.White);
                        }
                    }
                }
            }
        }
    }
}
