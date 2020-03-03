using System;
using Gtk;
using Mundus.Models;
using Mundus.Models.SuperLayers;
using Mundus.Views.Windows.Interfaces;

namespace Mundus.Views.Windows {
    public partial class SmallGameWindow : Gtk.Window, IGameWindow {
        /*Constant for the height and width of the game screen, map screens and inventory screen
         *and the width of stats, hotbar, accessories, gear & items on the ground menus*/
        public const int SIZE = 5;

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
            this.SetMapMenuVisibility(false);
            this.SetInvMenuVisibility(false);
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
                this.SetMapMenuVisibility(false);
            } else {
                this.PrintMap();
                this.SetMapMenuVisibility(true);
            }
        }

        private void SetMapMenuVisibility(bool isVisible) {
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
                this.SetInvMenuVisibility(false);
            } else {
                this.PrintInventory();
                this.SetInvMenuVisibility(true);
            }
        }

        private void SetInvMenuVisibility(bool isVisible) {
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

        public void PrintScreen() {
            //TODO: get the superlayer that the player is in
            ISuperLayer superLayer = LayerInstances.Land;

            for(int i = 0; i < 2; i++) {
                for (int row = 0; row < SIZE; row++) {
                    for (int col = 0; col < SIZE; col++) {
                        //Set the image to be either the ground layer tile, "blank" icon, item layer tile, mob layer tile or don't set it to anything 
                        //Note: first the ground and the blank icons are printed, then over them are printed the item tiles and over them are mob tiles
                        Image img = new Image();
                        if (i == 0) {
                            if (superLayer.GetGroundLayerTile( row, col ) == null) {
                                img = new Image( "blank", IconSize.Dnd );
                            }
                            else {
                                img = new Image( superLayer.GetGroundLayerTile( row, col ).stock_id, IconSize.Dnd );
                            }
                        } else {
                            if (superLayer.GetItemLayerTile( row, col ) == null) continue;
                            img = new Image( superLayer.GetItemLayerTile( row, col ).stock_id, IconSize.Dnd );
                        }

                        switch (row * 5 + col + 1) {
                            case 1: btnP1.Image = img; break;
                            case 2: btnP2.Image = img; break;
                            case 3: btnP3.Image = img; break;
                            case 4: btnP4.Image = img; break;
                            case 5: btnP5.Image = img; break;
                            case 6: btnP6.Image = img; break;
                            case 7: btnP7.Image = img; break;
                            case 8: btnP8.Image = img; break;
                            case 9: btnP9.Image = img; break;
                            case 10: btnP10.Image = img; break;
                            case 11: btnP11.Image = img; break;
                            case 12: btnP12.Image = img; break;
                            case 13: btnP13.Image = img; break;
                            case 14: btnP14.Image = img; break;
                            case 15: btnP15.Image = img; break;
                            case 16: btnP16.Image = img; break;
                            case 17: btnP17.Image = img; break;
                            case 18: btnP18.Image = img; break;
                            case 19: btnP19.Image = img; break;
                            case 20: btnP20.Image = img; break;
                            case 21: btnP21.Image = img; break;
                            case 22: btnP22.Image = img; break;
                            case 23: btnP23.Image = img; break;
                            case 24: btnP24.Image = img; break;
                            case 25: btnP25.Image = img; break;
                        }
                    }
                }
            }
        }

        public void PrintMap() {
            //TODO: get the superlayer that the player is in
            ISuperLayer superLayer = LayerInstances.Land;

            string sName;

            //Prints the "Ground layer" in map menu
            for (int row = 0; row < SIZE; row++) {
                for (int col = 0; col < SIZE; col++) {
                    //Print a tile if it exists, otherwise print the "blank" icon
                    if (superLayer.GetGroundLayerTile( row, col ) == null) {
                        sName = "blank";
                    }
                    else {
                        sName = superLayer.GetGroundLayerTile( row, col ).stock_id;
                    }

                    switch (row * 5 + col + 1) {
                        case 1: imgG1.SetFromStock(sName, IconSize.Dnd); break;
                        case 2: imgG2.SetFromStock( sName, IconSize.Dnd ); break;
                        case 3: imgG3.SetFromStock( sName, IconSize.Dnd ); break;
                        case 4: imgG4.SetFromStock( sName, IconSize.Dnd ); break;
                        case 5: imgG5.SetFromStock( sName, IconSize.Dnd ); break;
                        case 6: imgG6.SetFromStock( sName, IconSize.Dnd ); break;
                        case 7: imgG7.SetFromStock( sName, IconSize.Dnd ); break;
                        case 8: imgG8.SetFromStock( sName, IconSize.Dnd ); break;
                        case 9: imgG9.SetFromStock( sName, IconSize.Dnd ); break;
                        case 10: imgG10.SetFromStock( sName, IconSize.Dnd ); break;
                        case 11: imgG11.SetFromStock( sName, IconSize.Dnd ); break;
                        case 12: imgG12.SetFromStock( sName, IconSize.Dnd ); break;
                        case 13: imgG13.SetFromStock( sName, IconSize.Dnd ); break;
                        case 14: imgG14.SetFromStock( sName, IconSize.Dnd ); break;
                        case 15: imgG15.SetFromStock( sName, IconSize.Dnd ); break;
                        case 16: imgG16.SetFromStock( sName, IconSize.Dnd ); break;
                        case 17: imgG17.SetFromStock( sName, IconSize.Dnd ); break;
                        case 18: imgG18.SetFromStock( sName, IconSize.Dnd ); break;
                        case 19: imgG19.SetFromStock( sName, IconSize.Dnd ); break;
                        case 20: imgG20.SetFromStock( sName, IconSize.Dnd ); break;
                        case 21: imgG21.SetFromStock( sName, IconSize.Dnd ); break;
                        case 22: imgG22.SetFromStock( sName, IconSize.Dnd ); break;
                        case 23: imgG23.SetFromStock( sName, IconSize.Dnd ); break;
                        case 24: imgG24.SetFromStock( sName, IconSize.Dnd ); break;
                        case 25: imgG25.SetFromStock( sName, IconSize.Dnd ); break;
                    }
                }
            }

            //Prints the "Item layer" in map menu
            for (int row = 0; row < SIZE; row++) {
                for (int col = 0; col < SIZE; col++) {
                    //Print a tile if it exists, otherwise print the "blank" icon
                    if (superLayer.GetItemLayerTile( row, col ) == null) {
                        sName = "blank";
                    }
                    else {
                        sName = superLayer.GetItemLayerTile( row, col ).stock_id;
                    }

                    switch (row * 5 + col + 1) {
                        case 1: imgI1.SetFromStock( sName, IconSize.Dnd ); break;
                        case 2: imgI2.SetFromStock( sName, IconSize.Dnd ); break;
                        case 3: imgI3.SetFromStock( sName, IconSize.Dnd ); break;
                        case 4: imgI4.SetFromStock( sName, IconSize.Dnd ); break;
                        case 5: imgI5.SetFromStock( sName, IconSize.Dnd ); break;
                        case 6: imgI6.SetFromStock( sName, IconSize.Dnd ); break;
                        case 7: imgI7.SetFromStock( sName, IconSize.Dnd ); break;
                        case 8: imgI8.SetFromStock( sName, IconSize.Dnd ); break;
                        case 9: imgI9.SetFromStock( sName, IconSize.Dnd ); break;
                        case 10: imgI10.SetFromStock( sName, IconSize.Dnd ); break;
                        case 11: imgI11.SetFromStock( sName, IconSize.Dnd ); break;
                        case 12: imgI12.SetFromStock( sName, IconSize.Dnd ); break;
                        case 13: imgI13.SetFromStock( sName, IconSize.Dnd ); break;
                        case 14: imgI14.SetFromStock( sName, IconSize.Dnd ); break;
                        case 15: imgI15.SetFromStock( sName, IconSize.Dnd ); break;
                        case 16: imgI16.SetFromStock( sName, IconSize.Dnd ); break;
                        case 17: imgI17.SetFromStock( sName, IconSize.Dnd ); break;
                        case 18: imgI18.SetFromStock( sName, IconSize.Dnd ); break;
                        case 19: imgI19.SetFromStock( sName, IconSize.Dnd ); break;
                        case 20: imgI20.SetFromStock( sName, IconSize.Dnd ); break;
                        case 21: imgI21.SetFromStock( sName, IconSize.Dnd ); break;
                        case 22: imgI22.SetFromStock( sName, IconSize.Dnd ); break;
                        case 23: imgI23.SetFromStock( sName, IconSize.Dnd ); break;
                        case 24: imgI24.SetFromStock( sName, IconSize.Dnd ); break;
                        case 25: imgI25.SetFromStock( sName, IconSize.Dnd ); break;
                    }
                }
            }
        }

        public void PrintInventory() {

        }

        protected void OnBtnH1Clicked(object sender, EventArgs e) {
            this.PrintMap();
        }
    }
}
