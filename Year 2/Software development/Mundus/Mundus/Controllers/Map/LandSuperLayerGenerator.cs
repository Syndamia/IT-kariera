using System;
using Mundus.Models.Tiles;
using Mundus.Models.SuperLayers;

namespace Mundus.Controllers.Map {
    public class LandSuperLayerGenerator : ISuperLayerGenerator {
        public static void Generate(int size) {
            Land.Size = size;
            Land.SetGroundTiles(GenerateGroundLayer(size));
        }

        private static GroundTile[] GenerateGroundLayer(int size) {
            GroundTile[] tiles = new GroundTile[size];

            for(int index = 0; index < size; index++) {
                tiles[index] = Land.GetGroundTile( "Grass" );
            }
            return tiles;
        }

        private static ItemTile[,] GenerateItemLayer(int size) {
            throw new NotImplementedException();
        }
    }
}
