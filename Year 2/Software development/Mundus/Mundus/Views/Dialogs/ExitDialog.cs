using System;
namespace Mundus.Views.Dialogs {
    public partial class ExitDialog : Gtk.Dialog {
        public ExitDialog() {
            this.Build();
        }

        protected void OnDeleteEvent(object o, Gtk.DeleteEventArgs args) {
            //To keep window instance (it is needed (stored in WindowInstances.cs) until Application.Quit)
            args.RetVal = true;
        }
    }
}
