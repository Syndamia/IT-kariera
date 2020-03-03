using System;
using Mundus.Models;
using Mundus.Models.Tiles;
using Mundus.Models.SuperLayers;

namespace Mundus.Controllers.Map {
    public static class LandSuperLayerGenerator {
        public static void GenerateAllLayers(int size) {
            LayerInstances.Land.SetGroundLayer(GenerateGroundLayer(size));
            LayerInstances.Land.SetItemLayer(GenerateItemLayer(size));
        }

        private static GroundTile[,] GenerateGroundLayer(int size) {
            GroundTile[,] tiles = new GroundTile[size, size];

            for(int col = 0; col < size; col++) {
                for(int row = 0; row < size; row++) {
                    tiles[col, row] = LayerInstances.Land.GetGroundTileType("Grass");
                }
            }
            tiles[4, 2] = null;
            return tiles;
        }

        private static ItemTile[,] GenerateItemLayer(int size) {
            ItemTile[,] tiles = new ItemTile[size, size];
            for (int col = 0; col < size; col++) {
                for (int row = 0; row < size; row++) {
                    tiles[col, row] = null;
                }
            }
            tiles[1, 3] = LayerInstances.Land.GetItemTileType("Stick");
            tiles[3, 2] = LayerInstances.Land.GetItemTileType("Stick");
            return tiles;
        }
    }
}
