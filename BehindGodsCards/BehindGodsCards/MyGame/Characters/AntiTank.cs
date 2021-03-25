using System;
using System.Collections.Generic;
using System.Text;

namespace BehindGodsCards.MyGame.Characters
{
    class AntiTank : Units
    {
        public UnitsStats UnitsStats;
        public int HpDamage;
        public AntiTank(int UnitLvl) : base(UnitLvl)
        {
            Lvl = UnitLvl;
            UnitsStats = new UnitsStats();
        }
        public void Initialize(int Lvl)
        {
            switch (Lvl)
            {
                case 1:
                    Health = UnitsStats.antiTank.Lvl1.Health;
                    Damage = UnitsStats.antiTank.Lvl1.Damage;
                    Armor = UnitsStats.antiTank.Lvl1.Armor;
                    Cost = UnitsStats.antiTank.Lvl1.Cost;
                    HpDamage = UnitsStats.antiTank.Lvl1.HpDamage;
                    break;
                case 2:
                    Health = UnitsStats.antiTank.Lvl2.Health;
                    Damage = UnitsStats.antiTank.Lvl2.Damage;
                    Armor = UnitsStats.antiTank.Lvl2.Armor;
                    Cost = UnitsStats.antiTank.Lvl2.Cost;
                    HpDamage = UnitsStats.antiTank.Lvl2.HpDamage;
                    break;
                case 3:
                    Health = UnitsStats.antiTank.Lvl3.Health;
                    Damage = UnitsStats.antiTank.Lvl3.Damage;
                    Armor = UnitsStats.antiTank.Lvl3.Armor;
                    Cost = UnitsStats.antiTank.Lvl3.Cost;
                    HpDamage = UnitsStats.antiTank.Lvl3.HpDamage;
                    break;
            }

        }
    }
}
