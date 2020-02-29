using System;
using Gtk;
using Mundus.Models;
using Mundus.Views.Windows.Interfaces;
using Mundus.Models.SuperLayers;
using System.Linq;

namespace Mundus.Views.Windows {
    public partial class SmallGameWindow : Gtk.Window, IGameWindow {
        public SmallGameWindow() : base( Gtk.WindowType.Toplevel ) {
            this.Build();
        }

        public void OnDeleteEvent(object o, Gtk.DeleteEventArgs args) {
            //Open exit dialogue if you haven't saved in a while
            if (true) { //TODO: check if you have saved
                //TODO: pause game cycle

                ResponseType rt = (ResponseType)DialogInstances.DExit.Run();
                DialogInstances.DExit.Hide();

                if(rt == ResponseType.Cancel || rt == ResponseType.DeleteEvent) {
                    //cancel the exit procedure and keep the window open
                    args.RetVal = true;
                    return;
                }
                else if (rt == ResponseType.Accept) {
                    //TODO: call code for saving the game
                }
            }

            Application.Quit();
        }

        public void SetDefaults() {
            this.SetMapMenuVisible(false);
            this.SetInvMenuVisible(false);
            WindowInstances.WPause.GameWindow = this;
        }

        protected void OnBtnPauseClicked(object sender, EventArgs e) {
            //TODO: add code that stops (pauses) game cycle
            WindowInstances.WPause.Show();
        }

        protected void OnBtnMapClicked(object sender, EventArgs e) {
            //Hide inv menu, if it is visible (so only one of the two is visible)
            if (this.InvMenuIsVisible()) this.OnBtnInvClicked(this, null);

            if (this.MapMenuIsVisible()) {
                this.SetMapMenuVisible(false);
            } else {
                this.SetMapMenuVisible(true);
            }
        }

        private void SetMapMenuVisible(bool isVisible) {
            lblGroundLayer.Visible = isVisible;
            imgG1.Visible = isVisible;
            imgG2.Visible = isVisible;
            imgG3.Visible = isVisible;
            imgG4.Visible = isVisible;
            imgG5.Visible = isVisible;
            imgG6.Visible = isVisible;
            imgG7.Visible = isVisible;
            imgG8.Visible = isVisible;
            imgG9.Visible = isVisible;
            imgG10.Visible = isVisible;
            imgG11.Visible = isVisible;
            imgG12.Visible = isVisible;
            imgG13.Visible = isVisible;
            imgG14.Visible = isVisible;
            imgG15.Visible = isVisible;
            imgG16.Visible = isVisible;
            imgG17.Visible = isVisible;
            imgG18.Visible = isVisible;
            imgG19.Visible = isVisible;
            imgG20.Visible = isVisible;
            imgG21.Visible = isVisible;
            imgG22.Visible = isVisible;
            imgG23.Visible = isVisible;
            imgG24.Visible = isVisible;
            imgG25.Visible = isVisible;

            btnGM1.Visible = isVisible;
            btnGM2.Visible = isVisible;
            btnGM3.Visible = isVisible;

            lblItemLayer.Visible = isVisible;
            imgI1.Visible = isVisible;
            imgI2.Visible = isVisible;
            imgI3.Visible = isVisible;
            imgI4.Visible = isVisible;
            imgI5.Visible = isVisible;
            imgI6.Visible = isVisible;
            imgI7.Visible = isVisible;
            imgI8.Visible = isVisible;
            imgI9.Visible = isVisible;
            imgI10.Visible = isVisible;
            imgI11.Visible = isVisible;
            imgI12.Visible = isVisible;
            imgI13.Visible = isVisible;
            imgI14.Visible = isVisible;
            imgI15.Visible = isVisible;
            imgI16.Visible = isVisible;
            imgI17.Visible = isVisible;
            imgI18.Visible = isVisible;
            imgI19.Visible = isVisible;
            imgI20.Visible = isVisible;
            imgI21.Visible = isVisible;
            imgI22.Visible = isVisible;
            imgI23.Visible = isVisible;
            imgI24.Visible = isVisible;
            imgI25.Visible = isVisible;

            btnIM1.Visible = isVisible;
            btnIM2.Visible = isVisible;
            btnIM3.Visible = isVisible;

            lblBlank5.Visible = isVisible;
        }

        private bool MapMenuIsVisible() {
            return imgG1.Visible;
        }

        protected void OnBtnInvClicked(object sender, EventArgs e) {
            //Hide map menu, if it is visible (so only one of the two is visible)
            if (this.MapMenuIsVisible()) this.OnBtnMapClicked(this, null);

            if (btnI1.Visible) {
                this.SetInvMenuVisible(false);
            } else {
                this.SetInvMenuVisible(true);
            }
        }

        private void SetInvMenuVisible(bool isVisible) {
            btnI1.Visible = isVisible;
            btnI2.Visible = isVisible;
            btnI3.Visible = isVisible;
            btnI4.Visible = isVisible;
            btnI5.Visible = isVisible;
            btnI6.Visible = isVisible;
            btnI7.Visible = isVisible;
            btnI8.Visible = isVisible;
            btnI9.Visible = isVisible;
            btnI10.Visible = isVisible;
            btnI11.Visible = isVisible;
            btnI12.Visible = isVisible;
            btnI13.Visible = isVisible;
            btnI14.Visible = isVisible;
            btnI15.Visible = isVisible;
            btnI16.Visible = isVisible;
            btnI17.Visible = isVisible;
            btnI18.Visible = isVisible;
            btnI19.Visible = isVisible;
            btnI20.Visible = isVisible;
            btnI21.Visible = isVisible;
            btnI22.Visible = isVisible;
            btnI23.Visible = isVisible;
            btnI24.Visible = isVisible;
            btnI25.Visible = isVisible;

            lblAccessories.Visible = isVisible;
            btnA1.Visible = isVisible;
            btnA2.Visible = isVisible;
            btnA3.Visible = isVisible;
            btnA4.Visible = isVisible;
            btnA5.Visible = isVisible;
            btnA6.Visible = isVisible;
            btnA7.Visible = isVisible;
            btnA8.Visible = isVisible;
            btnA9.Visible = isVisible;
            btnA10.Visible = isVisible;

            lblGear.Visible = isVisible;
            btnG1.Visible = isVisible;
            btnG2.Visible = isVisible;
            btnG3.Visible = isVisible;
            btnG4.Visible = isVisible;
            btnG5.Visible = isVisible;

            lblItemsOnGround.Visible = isVisible;
            btnIG1.Visible = isVisible;
            btnIG2.Visible = isVisible;
            btnIG3.Visible = isVisible;
            btnIG4.Visible = isVisible;
            btnIG5.Visible = isVisible; 
            btnIG6.Visible = isVisible;
            btnIG7.Visible = isVisible;
            btnIG8.Visible = isVisible;
            btnIG9.Visible = isVisible;
            btnIG10.Visible = isVisible;

            lblBlank4.Visible = isVisible;
        }

        private bool InvMenuIsVisible() {
            return btnI1.Visible;
        }

        protected void OnBtnMusicClicked(object sender, EventArgs e) {
            WindowInstances.WMusic.Show();
        }

        public void PrintGameArea() {
            btnP1.Image = new Image(Land.GetGroundLayerTile( 0 ).stock_id, IconSize.Dnd);
            btnP2.Image = new Image( Land.GetGroundLayerTile( 1 ).stock_id, IconSize.Dnd );
            btnP3.Image = new Image( Land.GetGroundLayerTile( 2 ).stock_id, IconSize.Dnd );
            btnP4.Image = new Image( Land.GetGroundLayerTile( 3 ).stock_id, IconSize.Dnd );
            btnP5.Image = new Image( Land.GetGroundLayerTile( 4 ).stock_id, IconSize.Dnd );
            btnP6.Image = new Image( Land.GetGroundLayerTile( 5 ).stock_id, IconSize.Dnd );
            btnP7.Image = new Image( Land.GetGroundLayerTile( 6 ).stock_id, IconSize.Dnd );
            btnP8.Image = new Image( Land.GetGroundLayerTile( 7 ).stock_id, IconSize.Dnd );
            btnP9.Image = new Image( Land.GetGroundLayerTile( 8 ).stock_id, IconSize.Dnd );
            btnP10.Image = new Image( Land.GetGroundLayerTile( 9 ).stock_id, IconSize.Dnd );
            btnP11.Image = new Image( Land.GetGroundLayerTile( 10 ).stock_id, IconSize.Dnd );
            btnP12.Image = new Image( Land.GetGroundLayerTile( 11 ).stock_id, IconSize.Dnd );
            btnP13.Image = new Image( Land.GetGroundLayerTile( 12 ).stock_id, IconSize.Dnd );
            btnP14.Image = new Image( Land.GetGroundLayerTile( 13 ).stock_id, IconSize.Dnd );
            btnP15.Image = new Image( Land.GetGroundLayerTile( 14 ).stock_id, IconSize.Dnd );
            btnP16.Image = new Image( Land.GetGroundLayerTile( 15 ).stock_id, IconSize.Dnd );
            btnP17.Image = new Image( Land.GetGroundLayerTile( 16 ).stock_id, IconSize.Dnd );
            btnP18.Image = new Image( Land.GetGroundLayerTile( 17 ).stock_id, IconSize.Dnd );
            btnP19.Image = new Image( Land.GetGroundLayerTile( 18 ).stock_id, IconSize.Dnd );
            btnP20.Image = new Image( Land.GetGroundLayerTile( 19 ).stock_id, IconSize.Dnd );
            btnP21.Image = new Image( Land.GetGroundLayerTile( 20 ).stock_id, IconSize.Dnd );
            btnP22.Image = new Image( Land.GetGroundLayerTile( 21 ).stock_id, IconSize.Dnd );
            btnP23.Image = new Image( Land.GetGroundLayerTile( 22 ).stock_id, IconSize.Dnd );
            btnP24.Image = new Image( Land.GetGroundLayerTile( 23 ).stock_id, IconSize.Dnd );
            btnP25.Image = new Image( Land.GetGroundLayerTile( 24 ).stock_id, IconSize.Dnd );
        }

        protected void OnBtnH4Clicked(object sender, EventArgs e) {
            btnP17.Image = Land.GetGroundLayerTile( 17 ).Texture;
        }
    }
}
