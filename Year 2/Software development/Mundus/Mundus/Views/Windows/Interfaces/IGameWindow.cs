using System;
using Gtk;

namespace Mundus.Views.Windows.Interfaces {
    public interface IGameWindow {
        //Events that are generated from designer window
        void OnDeleteEvent(object o, Gtk.DeleteEventArgs args);
        
        void SetDefaults();
        void PrintScreen();
        void PrintMap();
        void PrintInventory();

        //Stuff that are in Gtk.Window class
        void Show();
    }
}
