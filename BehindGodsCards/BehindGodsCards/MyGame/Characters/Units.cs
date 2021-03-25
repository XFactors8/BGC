using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;


namespace BehindGodsCards.MyGame.Characters
{
    public class Units
    {
        public List<Animation> Animations;

        public int Health;
        public int Armor;
        public int Damage;
        public int Cost;
        public int Lvl;

        public string State;
        public string DirectionX; //Left Right
        public string DirectionY; //Up Down

        public Units(int UnitLvl)
        {
            State = "Walk";
            Lvl = UnitLvl;
        }
        public void Update()
        {
            for(int I = 0; I < Animations.Count; I++)
            {
                if (Animations[I].Name == State)
                {
                    Animations[I].Update();
                }
            }
        }
        
        public void TakeDamage(int Value)
        {
            Health -= Value - Armor;
        }
        public void UpdateState()
        {
            //si on change d'animation, ne pas oublier de reset les autres (sprites et délai)
        }
    }
}
