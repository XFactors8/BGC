using System;
using System.Collections.Generic;
using System.Text;

namespace BehindGodsCards.MyGame.Structures
{
    public class StructureStats
    {
        public Fields field;
        public Wall wall;
        public MainBase mainBase;
        public Barracks barracks; 


        public StructureStats()
        {
            field = new Fields();
            wall = new Wall();
            mainBase = new MainBase();
            barracks = new Barracks();
        }



        //-------------------------------------------------\\
        //----------------------FIELDS---------------------\\
        //-------------------------------------------------\\

        public struct Fields
        {
            public Lv1 Lvl1;
            public Lv2 Lvl2;
            public Lv3 Lvl3;

            public void Initialize()
            {
                Lvl1.Health = 1000;
                Lvl1.Armor = 0;

                Lvl2.Health = 1000;
                Lvl2.Armor = 0;

                Lvl3.Health = 1000;
                Lvl3.Armor = 0;
            }

            public struct Lv1
            {
                public int Health;
                public int Armor;
            }
            public struct Lv2
            {
                public int Health;
                public int Armor;
            }
            public struct Lv3
            {
                public int Health;
                public int Armor;
            }
        }



        //-------------------------------------------------\\
        //------------------------WALL---------------------\\
        //-------------------------------------------------\\

        public struct Wall
        {
            public Lv1 Lvl1;
            public Lv2 Lvl2;
            public Lv3 Lvl3;

            public void Initialize()
            {
                Lvl1.Health = 2000;
                Lvl1.Armor = 0;

                Lvl2.Health = 5000;
                Lvl2.Armor = 0;

                Lvl3.Health = 8000;
                Lvl3.Armor = 0;
            }

            public struct Lv1
            {
                public int Health;
                public int Armor;
            }
            public struct Lv2
            {
                public int Health;
                public int Armor;
            }
            public struct Lv3
            {
                public int Health;
                public int Armor;
            }
        }



        //-------------------------------------------------\\
        //---------------------MAIN BASE-------------------\\
        //-------------------------------------------------\\

        public struct MainBase
        {
            public Lv1 Lvl1;
            public Lv2 Lvl2;
            public Lv3 Lvl3;

            public void Initialize()
            {
                Lvl1.Health = 2000;
                Lvl1.Armor = 0;

                Lvl2.Health = 3000;
                Lvl2.Armor = 0;

                Lvl3.Health = 4000;
                Lvl3.Armor = 0;
            }

            public struct Lv1
            {
                public int Health;
                public int Armor;
            }
            public struct Lv2
            {
                public int Health;
                public int Armor;
            }
            public struct Lv3
            {
                public int Health;
                public int Armor;
            }
        }



        //-------------------------------------------------\\
        //----------------------BARRACKS-------------------\\
        //-------------------------------------------------\\

        public struct Barracks
        {
            public Lv1 Lvl1;
            public Lv2 Lvl2;
            public Lv3 Lvl3;

            public void Initialize()
            {
                Lvl1.Health = 1000;
                Lvl1.Armor = 0;

                Lvl2.Health = 1500;
                Lvl2.Armor = 0;

                Lvl3.Health = 2000;
                Lvl3.Armor = 0;
            }

            public struct Lv1
            {
                public int Health;
                public int Armor;
            }
            public struct Lv2
            {
                public int Health;
                public int Armor;
            }
            public struct Lv3
            {
                public int Health;
                public int Armor;
            }
        }

    }
}
