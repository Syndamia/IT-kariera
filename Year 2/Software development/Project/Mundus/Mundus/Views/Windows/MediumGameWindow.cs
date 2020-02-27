using System;
namespace Mundus.Views.Windows {
    public partial class MediumGameWindow : Gtk.Window {
        public MediumGameWindow() :
                base( Gtk.WindowType.Toplevel ) {
            this.Build();
        }
    }
}
