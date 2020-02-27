using System;
using Gtk;

namespace Mundus.Views.Windows {
    public partial class SmallGameWindow : Gtk.Window {
        public SmallGameWindow() : base( Gtk.WindowType.Toplevel ) {
            this.Build();
        }

        protected void OnDeleteEvent(object o, Gtk.DeleteEventArgs args) {
            //TODO: open exit dialogue if you haven't saved in a while

            Application.Quit();
            args.RetVal = true;
        }
    }
}
