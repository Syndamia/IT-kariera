using System;
using Gtk;
using Mundus.Models;

namespace Mundus.Views.Windows {
    public partial class MainWindow : Gtk.Window {
        public MainWindow() : base( Gtk.WindowType.Toplevel ) {
            this.Build();
        }

        private void OnDeleteEvent(object sender, DeleteEventArgs a) {
            Application.Quit();
            a.RetVal = true;
        }

        private void OnBtnNewGameClicked(object sender, EventArgs e) {
            this.Hide();
            WindowInstances.wNewGame.SetDefaults();
            WindowInstances.wNewGame.Show();
        }
        private void OnBtnNewGameActivated(object sender, EventArgs e) {
            //Pressing "enter" or "space" will also click the button
            this.OnBtnNewGameClicked(this, null);
        }

        private void OnBtnSettingsClicked(object sender, EventArgs e) {
            this.Hide();
            WindowInstances.wSettings.Show();
        }
        private void OnBtnSettingsActivated(object sender, EventArgs e) {
            //Pressing "enter" or "space" will also click the button
            this.OnBtnSettingsClicked(this, null);
        }
    }
}
