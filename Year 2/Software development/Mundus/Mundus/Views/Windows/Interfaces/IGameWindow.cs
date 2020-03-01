using System;
using Gtk;

namespace Mundus.Views.Windows.Interfaces {
    public interface IGameWindow {
        void SetDefaults();
        void OnDeleteEvent(object o, Gtk.DeleteEventArgs args);
    }
}
