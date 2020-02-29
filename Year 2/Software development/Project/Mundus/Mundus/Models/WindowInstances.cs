using System;
using Mundus.Views.Windows;

namespace Mundus.Models {
    public static class WindowInstances {
        public static MainWindow WMain { get; private set; }
        public static NewGameWindow WNewGame { get; private set; }
        public static SmallGameWindow WSGame { get; private set; }
        public static MediumGameWindow WMGame { get; private set; }
        public static LargeGameWindow WLGame { get; private set; }
        public static SettingsWindow WSettings { get; private set; }
        public static PauseWindow WPause { get; private set; }
        public static MusicWindow WMusic { get; private set; }

        public static void CreateInstances() {
            WMain = new MainWindow();
            WNewGame = new NewGameWindow();
            WSGame = new SmallGameWindow();
            WMGame = new MediumGameWindow();
            WLGame = new LargeGameWindow();
            WSettings = new SettingsWindow();
            WPause = new PauseWindow();
            WMusic = new MusicWindow();

            HideAll();
        }

        //Gtk opens all window instances in the project automatically, unless they are hidden
        private static void HideAll() {
            WMain.Hide();
            WNewGame.Hide();
            WSGame.Hide();
            WMGame.Hide();
            WLGame.Hide();
            WSettings.Hide();
            WPause.Hide();
            WMusic.Hide();
        }
    }
}
