﻿namespace Ex04.Menus.Interfaces
{
    public class MainMenu : MenuItem
    {
        private const string k_MainTitle = "Interface Main Menu";

        public MainMenu() : base(k_MainTitle)
        {
        }

        public void Show()
        {
            RunMenu();
        }

        protected override string GetReturnButton()
        {
            return "Exit";
        }
    }
}
