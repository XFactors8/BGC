using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BehindGodsCards.MyGame.Structures
{
    public class Batiments
    {
        public int Hp;
        public int Def;
        public Batiments()
        {
            Def = 0;
        }
        
        public void TakeDamage(int Amount)
        {
            Hp = Hp - (Amount - Def);
        }
    }
}
