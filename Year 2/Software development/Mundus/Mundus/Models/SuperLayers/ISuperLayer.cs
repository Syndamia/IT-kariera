using System;
using System.Collections.Generic;
using Mundus.Models.Tiles;
using Gtk;

namespace Mundus.Models.SuperLayers {
    public interface ISuperLayer {
        ItemTile GetItemTileType(string name);
        GroundTile GetGroundTileType(string name);

        ItemTile GetItemLayerTile(int yPos, int xPos);
        GroundTile GetGroundLayerTile(int yPos, int xPos);

        void SetItemLayer(ItemTile[,] itemTiles);
        void SetGroundLayer(GroundTile[,] groundTiles);
    }
}
