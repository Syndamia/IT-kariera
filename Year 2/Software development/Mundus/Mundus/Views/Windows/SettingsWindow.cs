using System;
using Gtk;
using Mundus.Models;

namespace Mundus.Views.Windows {
    public partial class SettingsWindow : Gtk.Window {
        //This is used to show the sender (the window that showed this one) when you close this window
        public Window Sender { get; private set; }

        public SettingsWindow() : base( Gtk.WindowType.Toplevel ) {
            this.Build();
        }

        private void OnDeleteEvent(object sender, DeleteEventArgs a) {
            //Return to the sender window (and dont destroy the settings window instance)
            this.OnBtnBackClicked(this, null);
            a.RetVal = true;
        }

        public void Show(Window sender) {
            this.Show();
            this.Sender = sender;
        }

        private void OnBtnBackClicked(object sender, EventArgs e) {
            this.Hide();
            Sender.Show();
        }
    }
}
