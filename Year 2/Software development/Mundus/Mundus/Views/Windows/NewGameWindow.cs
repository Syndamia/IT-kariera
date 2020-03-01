using System;
using Gtk;
using Mundus.Models;
using Mundus.Controllers.Map;

namespace Mundus.Views.Windows {
    public partial class NewGameWindow : Gtk.Window {
        public NewGameWindow() : base( Gtk.WindowType.Toplevel ) {
            this.Build();
        }

        private void OnDeleteEvent(object sender, DeleteEventArgs a) {
            this.OnBtnBackClicked(this, null);
            a.RetVal = true;
        }

        private void OnBtnBackClicked(object sender, EventArgs e) {
            this.Hide();
            WindowInstances.WMain.Show();
        }

        //You can choose your Map size only in creative, it is predetermined by screen & inventory size in survival.
        private void OnRbCreativeToggled(object sender, EventArgs e) {
            if (rbCreative.Active) {
                rbMSmall.Sensitive = true;
                rbMMedium.Sensitive = true;
                rbMLarge.Sensitive = true;
            } else {
                rbMSmall.Sensitive = false;
                rbMMedium.Sensitive = false;
                rbMLarge.Sensitive = false;
                this.SetMapSize(); //in case (in creative) you selected screen & inventory and map sizes that are invalid in survival
            }
        }

        /*Sometimes the default values get messed up and you could have, for example, 
         *a large map with large screen & inventory on survival. This prevents that.*/
        public void SetDefaults() {
            rbSurvival.Active = true;
            rbEasy.Active = true;
            rbSmall.Active = true;
            SetMapSize();

            rbMSmall.Sensitive = false;
            rbMMedium.Sensitive = false;
            rbMLarge.Sensitive = false;
        }

        //Automatically set map sizes from screen & inventory size only in survival mode
        private void OnRbSmallToggled(object sender, EventArgs e) {
            if (rbSurvival.Active) {
                this.SetMapSize();
            }
        }
        private void OnRbMediumToggled(object sender, EventArgs e) {
            if (rbSurvival.Active) {
                this.SetMapSize();
            }
        }
        private void OnRbLargeToggled(object sender, EventArgs e) {
            if (rbSurvival.Active) {
                this.SetMapSize();
            }
        }

        //Sets map size from screen & inventory size
        private void SetMapSize() {
            if (rbSmall.Active) {
                rbMLarge.Active = true;
            } 
            else if (rbMedium.Active) {
                rbMMedium.Active = true;
            } 
            else if (rbLarge.Active) {
                rbMSmall.Active = true;
            }
        }

        protected void OnBtnGenerateClicked(object sender, EventArgs e) {
            //TODO: add settings to a model

            this.Hide();
            if (rbSmall.Active) {
                LandSuperLayerGenerator.Generate( 25 );
                WindowInstances.WSGame.PrintGameArea();
                WindowInstances.WSGame.SetDefaults();
                WindowInstances.WSGame.Show();
            }
            else if (rbMedium.Active) {
                WindowInstances.WMGame.Show();
            }
            else if (rbLarge.Active) {
                WindowInstances.WLGame.Show();
            }
        }
    }
}
