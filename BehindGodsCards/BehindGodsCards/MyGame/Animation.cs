using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace BehindGodsCards.MyGame
{
    public class Animation
    {
        public string Type;
        public int ToAdd;
        public string Name;
        public double Delay;
        public double DelayCount;
        public int TextureNumber;
        public List<Texture2D> Textures;
        public Animation(string name, List<string> spritesToAdd, double delay, string type)
        {
            Type = type;
            Name = name;
            Delay = delay;
            DelayCount = 0;
            ToAdd = 1;
            Textures = new List<Texture2D>();
            foreach(string Sprite in spritesToAdd)
            {
                Textures.Add(GeneralFunctions.Content.Load<Texture2D>("GameContent\\" + Sprite));
            }
        }
        public void Update()
        {
            DelayCount += 1 * GeneralFunctions.GameTime.ElapsedGameTime.TotalSeconds;
            if (DelayCount >= Delay)
            {
                TextureNumber += ToAdd;
                DelayCount = 0;
                if (Type == "Reverse")
                {
                    if (TextureNumber == Textures.Count - 1 && ToAdd > 0)
                    {
                        ToAdd = 0 - ToAdd;
                    }
                    if (TextureNumber == 0 && ToAdd < 0)
                    {
                        ToAdd = 0 - ToAdd;
                    }
                }
                if (Type == "Basic")
                {
                    if (TextureNumber == Textures.Count)
                    {
                        TextureNumber -= Textures.Count;
                    }    
                }
            }
        }
    }
}
