using System;
namespace Mundus.Views.Windows {
    public partial class CraftingWindow : Gtk.Window {
        public CraftingWindow() :
                base( Gtk.WindowType.Toplevel ) {
            this.Build();
        }
    }
}
