using System;
using Gtk;
using Mundus.Views.Windows.Interfaces;

namespace Mundus.Views.Windows {
    public partial class MediumGameWindow : Gtk.Window, IGameWindow {
        public MediumGameWindow() : base( Gtk.WindowType.Toplevel ) {
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
