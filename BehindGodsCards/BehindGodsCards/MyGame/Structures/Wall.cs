using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BehindGodsCards.MyGame.Structures
{
    public class Wall : Batiments
    {

        public StructureStats StructStats;
        public int Hp;
        public int Armor;
        public int MaxUnits;
        public int Lvl;
        public int MaxUnit;
        public int UnitOnit;

        public Wall()
        {
            StructStats = new StructureStats();
            Lvl = 1;
            Hp = StructStats.wall.Lvl1.Health;
            Armor = StructStats.wall.Lvl1.Armor;
        }

        public void Update()
        {

        }

        public void LevelUp()
        {
            Lvl = Lvl + 1;
            if (Lvl == 2)
            {
                Hp = StructStats.wall.Lvl2.Health;
                Armor = StructStats.wall.Lvl2.Armor;
            }
            if (Lvl == 3)
            {
                Hp = StructStats.wall.Lvl3.Health;
                Armor = StructStats.wall.Lvl3.Armor;
            }
        }
    }
}
