using System;
using System.Collections.Generic;
using Mundus.Models.Tiles;
using Gtk;

namespace Mundus.Models.SuperLayers {
    public abstract class SuperLayer {
        public static int Size { get; set; }

        protected static Dictionary<string, ItemTile> ItemTiles;
        protected static Dictionary<string, GroundTile> GroundTiles;

        protected static GroundTile[] GroundLayer;
        protected static ItemTile[] ItemLayer;

        public static GroundTile GetGroundTile(string name) {
            return GroundTiles[name];
        }

        public static ItemTile GetItemTile(string name) {
            return ItemTiles[name];
        }

        public static GroundTile GetGroundLayerTile(int index) {
            return GroundLayer[index];
        }

        public static ItemTile GetItemLayerTile(int index) {
            return ItemLayer[index];
        }

        public static void GenerateLayers() {
            throw new NotImplementedException();
        }
    }
}
