using System;
using Mundus.Models;
using Mundus.Models.Tiles;
using Mundus.Models.SuperLayers;

namespace Mundus.Controllers.Map {
    public static class LandSuperLayerGenerator {
        private static Random rnd;

        public static void GenerateAllLayers(int size) {
            LayerInstances.Land.SetGroundLayer(GenerateGroundLayer(size));
            LayerInstances.Land.SetItemLayer(GenerateItemLayer(size));
        }

        private static GroundTile[,] GenerateGroundLayer(int size) {
            rnd = new Random();
            GroundTile[,] tiles = new GroundTile[size, size];

            for(int col = 0; col < size; col++) {
                for(int row = 0; row < size; row++) {
                    tiles[col, row] = LayerInstances.Land.GetGroundTileType("Grass");
                }
            }
            return tiles;
        }

        private static ItemTile[,] GenerateItemLayer(int size) {
            ItemTile[,] tiles = new ItemTile[size, size];
            for (int col = 0; col < size; col++) {
                for (int row = 0; row < size; row++) {
                    if (rnd.Next( 0, 5 ) == 1) {
                        tiles[col, row] = LayerInstances.Land.GetItemTileType( "Boulder" );
                    }
                }
            }
            return tiles;
        }
    }
}
