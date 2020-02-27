using System;
namespace Mundus.Views.Windows {
    public partial class MusicWindow : Gtk.Window {
        public MusicWindow() :
                base( Gtk.WindowType.Toplevel ) {
            this.Build();
        }
    }
}
