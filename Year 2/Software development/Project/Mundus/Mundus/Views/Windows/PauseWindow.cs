using System;
namespace Mundus.Views.Windows {
    public partial class PauseWindow : Gtk.Window {
        public PauseWindow() :
                base( Gtk.WindowType.Toplevel ) {
            this.Build();
        }
    }
}
