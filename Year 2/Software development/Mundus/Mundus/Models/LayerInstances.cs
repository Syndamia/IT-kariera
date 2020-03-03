using System;
using Mundus.Models.SuperLayers;

namespace Mundus.Models {
    public static class LayerInstances {
        //add other layers
        public static Land Land { get; private set; }

        public static void CreateInstances() {
            Land = new Land();
        }
    }
}
