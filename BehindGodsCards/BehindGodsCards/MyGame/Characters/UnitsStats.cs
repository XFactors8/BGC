using System;
using System.Collections.Generic;
using System.Text;

namespace BehindGodsCards.MyGame.Characters
{
    public class UnitsStats
    {
        public Cac cac;
        public Range range;
        public Tank tank;
        public AntiTank antiTank;

        public UnitsStats()
        {
            cac = new Cac();
            range = new Range();
            tank = new Tank();
            antiTank = new AntiTank();
            
            cac.Initialize();
            range.Initialize();
            tank.Initialize();
            antiTank.Initialize();
        }



        //-------------------------------------------------\\
        //------------------------CAC----------------------\\
        //-------------------------------------------------\\
        public struct Cac
        {
            public Lv1 Lvl1;
            public Lv2 Lvl2;
            public Lv3 Lvl3;

            public void Initialize()
            {
                Lvl1.Health = 80;
                Lvl1.Damage = 20;
                Lvl1.Armor = 0;
                Lvl1.Cost = 25;

                Lvl2.Health = 95;
                Lvl2.Damage = 25;
                Lvl2.Armor = 0;
                Lvl2.Cost = 35;

                Lvl3.Health = 110;
                Lvl3.Damage = 30;
                Lvl3.Armor = 0;
                Lvl3.Cost = 45;
            }

            public struct Lv1
            {
                public int Health;
                public int Armor;
                public int Damage;
                public int Cost;
            }
            public struct Lv2
            {
                public int Health;
                public int Armor;
                public int Damage;
                public int Cost;
            }
            public struct Lv3
            {
                public int Health;
                public int Armor;
                public int Damage;
                public int Cost;
            }
        }



        //-------------------------------------------------\\
        //-----------------------RANGE---------------------\\
        //-------------------------------------------------\\
        public struct Range
        {
            public Lv1 Lvl1;
            public Lv2 Lvl2;
            public Lv3 Lvl3;

            public void Initialize()
            {
                Lvl1.Health = 50;
                Lvl1.Damage = 30;
                Lvl1.Armor = 0;
                Lvl1.Cost = 35;

                Lvl2.Health = 55;
                Lvl2.Damage = 40;
                Lvl2.Armor = 0;
                Lvl2.Cost = 45;

                Lvl3.Health = 60;
                Lvl3.Damage = 50;
                Lvl3.Armor = 0;
                Lvl3.Cost = 55;
            }

            public struct Lv1
            {
                public int Health;
                public int Armor;
                public int Damage;
                public int Cost;
            }
            public struct Lv2
            {
                public int Health;
                public int Armor;
                public int Damage;
                public int Cost;
            }
            public struct Lv3
            {
                public int Health;
                public int Armor;
                public int Damage;
                public int Cost;
            }
        }



        //-------------------------------------------------\\
        //------------------------TANK---------------------\\
        //-------------------------------------------------\\
        public struct Tank
        {
            public Lv1 Lvl1;
            public Lv2 Lvl2;
            public Lv3 Lvl3;

            public void Initialize()
            {
                Lvl1.Health = 150;
                Lvl1.Damage = 10;
                Lvl1.Armor = 0;
                Lvl1.Cost = 60;

                Lvl2.Health = 175;
                Lvl2.Damage = 15;
                Lvl2.Armor = 0;
                Lvl2.Cost = 70;

                Lvl3.Health = 200;
                Lvl3.Damage = 20;
                Lvl3.Armor = 0;
                Lvl3.Cost = 80;
            }

           public struct Lv1
            {
                public int Health;
                public int Armor;
                public int Damage;
                public int Cost;
            }
            public struct Lv2
            {
                public int Health;
                public int Armor;
                public int Damage;
                public int Cost;
            }
            public struct Lv3
            {
                public int Health;
                public int Armor;
                public int Damage;
                public int Cost;
            }
        }



        //-------------------------------------------------\\
        //----------------------ANTITANK-------------------\\
        //-------------------------------------------------\\
        public struct AntiTank
        {
            public Lv1 Lvl1;
            public Lv2 Lvl2;
            public Lv3 Lvl3;

            public void Initialize()
            {
                Lvl1.Health = 60;
                Lvl1.Damage = 15;
                Lvl1.Armor = 0;
                Lvl1.Cost = 50;
                Lvl1.HpDamage = 15;

                Lvl2.Health = 70;
                Lvl2.Damage = 20;
                Lvl2.Armor = 0;
                Lvl2.Cost = 65;
                Lvl2.HpDamage = 20;

                Lvl3.Health = 80;
                Lvl3.Damage = 25;
                Lvl3.Armor = 0;
                Lvl3.Cost = 80;
                Lvl3.HpDamage = 25;
            }

            public struct Lv1
            {
                public int Health;
                public int Armor;
                public int Damage;
                public int Cost;
                public int HpDamage;
            }
            public struct Lv2
            {
                public int Health;
                public int Armor;
                public int Damage;
                public int Cost;
                public int HpDamage;
            }
            public struct Lv3
            {
                public int Health;
                public int Armor;
                public int Damage;
                public int Cost;
                public int HpDamage;
            }
        }
    }
}