using System;
namespace Mundus.Views.Windows {
    public partial class LargeGameWindow : Gtk.Window {
        public LargeGameWindow() :
                base( Gtk.WindowType.Toplevel ) {
            this.Build();
        }
    }
}
