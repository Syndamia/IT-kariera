using System;
using System.Collections.Generic;
using Mundus.Models.Tiles;

namespace Mundus.Models.SuperLayers {
    public class Land : SuperLayer {
        protected static Dictionary<string, GroundTile> GroundTiles = new Dictionary<string, GroundTile> {
            {"Grass", new GroundTile("grass")}
        };

        public static void SetGroundTiles(GroundTile[] groundTiles) {
            GroundLayer = groundTiles;
        }

        public static GroundTile GetGroundTile(string name) {
            return GroundTiles[name];
        }

    }
}
