using System;
using Gtk;
using Mundus.Models;

namespace Mundus.Views.Windows {
    public partial class SettingsWindow : Gtk.Window {
        public SettingsWindow() : base( Gtk.WindowType.Toplevel ) {
            this.Build();
        }

        private void OnDeleteEvent(object sender, DeleteEventArgs a) {
            Application.Quit();
            a.RetVal = true;
        }

        private void OnBtnBackClicked(object sender, EventArgs e) {
            this.Hide();
            WindowInstances.wMain.Show();
        }
        private void OnBtnBackActivated(object sender, EventArgs e) {
            //Pressing "enter" or "space" will also click the button
            this.OnBtnBackClicked(this, null);
        }
    }
}
