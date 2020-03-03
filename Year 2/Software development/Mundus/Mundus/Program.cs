using System;
using Gtk;
using Mundus.Models;

namespace Mundus {
    public static class MainClass {
        public static void Main(string[] args) {
            Application.Init();
            //All windows that are used by user (instances) are saved and created in WindowInstances.cs
            WindowInstances.CreateInstances();
            DialogInstances.CreateInstances();
            LayerInstances.CreateInstances();

            WindowInstances.WMain.Show();
            Application.Run();
        }
    }
}
