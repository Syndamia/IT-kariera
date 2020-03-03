using System;
using Mundus.Views.Windows.Interfaces;
using Gtk;

namespace Mundus.Views.Windows {
    public partial class LargeGameWindow : Gtk.Window, IGameWindow {
        public LargeGameWindow() : base( Gtk.WindowType.Toplevel ) {
            this.Build();
        }

        public void OnDeleteEvent(object o, DeleteEventArgs args) {
            throw new NotImplementedException();
        }

        public void PrintAll() {
            throw new NotImplementedException();
        }

        public void PrintInventory() {
            throw new NotImplementedException();
        }

        public void PrintMap() {
            throw new NotImplementedException();
        }

        public void PrintScreen() {
            throw new NotImplementedException();
        }

        public void SetDefaults() {
            throw new NotImplementedException();
        }
    }
}
