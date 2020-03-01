using System;
using Gtk;

namespace Mundus.Models.Tiles {
    public interface ITile {
        string stock_id { get; }
        Image Texture { get; }
    }
}
