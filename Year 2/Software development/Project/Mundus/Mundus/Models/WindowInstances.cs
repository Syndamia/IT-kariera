using System;
using Mundus.Views.Windows;

namespace Mundus.Models {
    public static class WindowInstances {
        public static MainWindow wMain { get; private set; }
        public static NewGameWindow wNewGame { get; private set; }
        public static SmallGameWindow wSGame { get; private set; }
        public static MediumGameWindow wMGame { get; private set; }
        public static LargeGameWindow wLGame { get; private set; }
        public static SettingsWindow wSettings { get; private set; }
        public static PauseWindow wPause { get; private set; }
        public static MusicWindow wMusic { get; private set; }

        public static void CreateInstances() {
            wMain = new MainWindow();
            wNewGame = new NewGameWindow();
            wSGame = new SmallGameWindow();
            wMGame = new MediumGameWindow();
            wLGame = new LargeGameWindow();
            wSettings = new SettingsWindow();
            wPause = new PauseWindow();
            wMusic = new MusicWindow();
            HideAll();
        }

        //Gtk opens all window instances in the project, uness they are hidden
        private static void HideAll() {
            wMain.Hide();
            wNewGame.Hide();
            wSGame.Hide();
            wMGame.Hide();
            wLGame.Hide();
            wSettings.Hide();
            wPause.Hide();
            wMusic.Hide();
        }
    }
}
