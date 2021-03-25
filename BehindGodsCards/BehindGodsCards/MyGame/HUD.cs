using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace BehindGodsCards.MyGame
{
    public class HUD
    {
        public bool InUnits;
        public bool InUpgrade;

        public Div UnitManagment;
        public Div MainUI;
        public Div CreateUnit;
        public Div UpgradeBuilding;

        public bool Selected;
        public bool Clicked;
        
        public HUD()
        {
            MainUI = new Div("MainUI");
            CreateUnit = new Div("CreateUnit");
            UnitManagment = new Div("UnitManagment");
            UpgradeBuilding = new Div("UpgradeBuilding");

            LoadContent();
            //===============\\
            //=====Main UI====\\
            //================\\
            int ButtonSpace = ((((MainUI.Buttons.Count * MainUI.Buttons[0].Sprite.Width) * 2) - MainUI.Buttons.Count * MainUI.Buttons[0].Sprite.Width) / MainUI.Buttons.Count) / 2;
            for(int I = 0; I < MainUI.Buttons.Count; I++)
            {
                MainUI.Buttons[I].Position.X = MainUI.Position.X + ((I + 1) * ButtonSpace + I * MainUI.Buttons[I].Sprite.Width);
                MainUI.Buttons[I].Position.Y = MainUI.Position.Y + 20;
            }
            MainUI.Position.X = GeneralFunctions.ScreenWidth - (MainUI.Buttons[3].Position.X + MainUI.Buttons[3].Sprite.Width + ButtonSpace);
            MainUI.Position.Y = 0;
            //===============\\
            //=UnitManagment=\\
            //===============\\
            for (int I = 0; I < UnitManagment.Buttons.Count; I++)
            {
                UnitManagment.Buttons[I].Position.X = 10;
                UnitManagment.Buttons[I].Position.Y = I * UnitManagment.Buttons[I].Sprite.Height + (I + 1) *5;
            }
            UnitManagment.Position.X = 0;
            UnitManagment.Position.Y = 0;

        }

        public void Update()
        {
            MainUI.Update();
            CreateUnit.Update();
            UnitManagment.Update();
            UpgradeBuilding.Update();
        }

        public void Draw()
        {
            MainUI.Draw();
            UnitManagment.Draw();
        }
        public void LoadContent()
        {
            //MainUI---
            MainUI.AddButton("Units", "GameContent\\HUD\\Units", "GameContent\\HUD\\Units", "GameContent\\HUD\\Units");
            MainUI.AddButton("Upgrade", "GameContent\\HUD\\Upgrade", "GameContent\\HUD\\Upgrade", "GameContent\\HUD\\Upgrade");
            MainUI.AddButton("Stats", "GameContent\\HUD\\Stats", "GameContent\\HUD\\Stats", "GameContent\\HUD\\Stats");
            MainUI.AddButton("Menu", "GameContent\\HUD\\Menu", "GameContent\\HUD\\Menu", "GameContent\\HUD\\Menu");

            //UnitManagment
            UnitManagment.AddButton("Attack", "GameContent\\HUD\\Attack", "GameContent\\HUD\\AttackSelected", "GameContent\\HUD\\AttackClicked", "GameContent\\HUD\\AttackSelectedClicked");
            UnitManagment.AddButton("Defend", "GameContent\\HUD\\Defend", "GameContent\\HUD\\DefendSelected", "GameContent\\HUD\\DefendClicked", "GameContent\\HUD\\DefendSelectedClicked");
            UnitManagment.AddButton("Protect", "GameContent\\HUD\\Cover", "GameContent\\HUD\\CoverSelected", "GameContent\\HUD\\CoverClicked", "GameContent\\HUD\\CoverSelectedClicked");
        }
    }
}
