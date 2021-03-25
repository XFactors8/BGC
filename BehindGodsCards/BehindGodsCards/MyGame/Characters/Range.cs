using System;
using System.Collections.Generic;
using System.Text;

namespace BehindGodsCards.MyGame.Characters
{
    class Range : Units
    {
        public UnitsStats UnitsStats;

        public Range(int UnitLvl) : base(UnitLvl)
        {
            Lvl = UnitLvl;
            UnitsStats = new UnitsStats();
        }
        public void Initialize(int Lvl)
        {
            switch (Lvl)
            {
                case 1:
                    Health = UnitsStats.range.Lvl1.Health;
                    Damage = UnitsStats.range.Lvl1.Damage;
                    Armor = UnitsStats.range.Lvl1.Armor;
                    Cost = UnitsStats.range.Lvl1.Cost;
                    break;
                case 2:
                    Health = UnitsStats.range.Lvl2.Health;
                    Damage = UnitsStats.range.Lvl2.Damage;
                    Armor = UnitsStats.range.Lvl2.Armor;
                    Cost = UnitsStats.range.Lvl2.Cost;
                    break;
                case 3:
                    Health = UnitsStats.range.Lvl3.Health;
                    Damage = UnitsStats.range.Lvl3.Damage;
                    Armor = UnitsStats.range.Lvl3.Armor;
                    Cost = UnitsStats.range.Lvl3.Cost;
                    break;
            }

        }
    }
}
