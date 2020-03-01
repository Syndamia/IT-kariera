using System;
using System.Media;
using Gtk;
using System.Linq;

namespace Mundus.Views.Windows {
    public partial class MusicWindow : Gtk.Window {
        private SoundPlayer sp;

        public MusicWindow() : base( Gtk.WindowType.Toplevel ) {
            this.Build();
            sp = new SoundPlayer();
        }

        protected void OnDeleteEvent(object o, DeleteEventArgs args) {
            this.OnBtnBackClicked(this, null);
            args.RetVal = true;
        }

        protected void OnBtnBackClicked(object sender, EventArgs e) {
            //TODO: resume game loop
            this.Hide();
        }

        protected void OnBtnPlayClicked(object sender, EventArgs e) {
            sp.SoundLocation = fcMusic.Filename;
            sp.Play();
        }

        protected void OnFcMusicSelectionChanged(object sender, EventArgs e) {
            lblPath.Text = fcMusic.Filename;
        }

        protected void OnBtnStopClicked(object sender, EventArgs e) {
            sp.Stop();
        }

        protected void OnBtnNextClicked(object sender, EventArgs e) {

        }

    }
}
