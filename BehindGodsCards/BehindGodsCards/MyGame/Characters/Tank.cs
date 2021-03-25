using System;
using System.Collections.Generic;
using System.Text;

namespace BehindGodsCards.MyGame.Characters
{
    class Tank :Units
    {
        public UnitsStats UnitsStats;

        public Tank (int UnitLvl) : base(UnitLvl)
        {
            Lvl = UnitLvl;
            UnitsStats = new UnitsStats();
        }
        public void Initialize(int Lvl)
        {
            switch (Lvl)
            {
                case 1:
                    Health = UnitsStats.tank.Lvl1.Health;
                    Damage = UnitsStats.tank.Lvl1.Damage;
                    Armor = UnitsStats.tank.Lvl1.Armor;
                    Cost = UnitsStats.tank.Lvl1.Cost;
                    break;
                case 2:
                    Health = UnitsStats.tank.Lvl2.Health;
                    Damage = UnitsStats.tank.Lvl2.Damage;
                    Armor = UnitsStats.tank.Lvl2.Armor;
                    Cost = UnitsStats.tank.Lvl2.Cost;
                    break;
                case 3:
                    Health = UnitsStats.tank.Lvl3.Health;
                    Damage = UnitsStats.tank.Lvl3.Damage;
                    Armor = UnitsStats.tank.Lvl3.Armor;
                    Cost = UnitsStats.tank.Lvl3.Cost;
                    break;
            }

        }
    }
}