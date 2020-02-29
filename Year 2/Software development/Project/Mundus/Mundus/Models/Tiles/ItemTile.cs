using System;
using Gtk;

namespace Mundus.Models.Tiles {
    public class ItemTile {
        public string stock_id { get; private set; }
        public Image Texture { get; private set; }

        public ItemTile(string stock_id) {
            this.stock_id = stock_id;
            this.Texture = new Image( stock_id, IconSize.Dnd );
        }

        public ItemTile(Image texture) {
            this.stock_id = texture.Name;
            this.Texture = texture;
        }
    }
}
