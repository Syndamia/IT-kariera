using System;
using System.Collections.Generic;
using Mundus.Models.Tiles;

namespace Mundus.Models.SuperLayers {
    public class Land : ISuperLayer {

        private static Dictionary<string, ItemTile> itemTilesTypes = new Dictionary<string, ItemTile> {
            {"Stick", new ItemTile("stick")},
            {"Boulder", new ItemTile("boulder")}
        };
        private static Dictionary<string, GroundTile> groundTilesTypes = new Dictionary<string, GroundTile> {
            {"Grass", new GroundTile("grass")}
        };

        private static ItemTile[,] itemLayer;
        private static GroundTile[,] groundLayer;

        public Land() { }

        public ItemTile GetItemTileType(string name) {
            return itemTilesTypes[name];
        }
        public GroundTile GetGroundTileType(string name) {
            return groundTilesTypes[name];
        }

        public ItemTile GetItemLayerTile(int yPos, int xPos) {
            return itemLayer[yPos, xPos];
        }
        public GroundTile GetGroundLayerTile(int yPos, int xPos) {
            return groundLayer[yPos, xPos];
        }

        public void SetItemLayer(ItemTile[,] itemTiles) {
            itemLayer = itemTiles;
        }
        public void SetGroundLayer(GroundTile[,] groundTiles) {
            groundLayer = groundTiles;
        }
    }
}
