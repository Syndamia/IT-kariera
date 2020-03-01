using System;
using Mundus.Views.Dialogs;

namespace Mundus.Models {
    public static class DialogInstances {
        public static ExitDialog DExit { get; private set; }

        public static void CreateInstances() {
            DExit = new ExitDialog();

            HideAll();
        }

        //Gtk opens all dialog (window) instances in the project automatically, unless they are hidden
        private static void HideAll() {
            DExit.Hide();
        }
    }
}
