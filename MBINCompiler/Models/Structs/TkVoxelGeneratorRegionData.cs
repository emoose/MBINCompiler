using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkVoxelGeneratorRegionData : NMSTemplate // 0x50 bytes
    {
        public float PlanetRadius;
        public float VoronoiPointDivisions;
        public int VoronoiSectorSeed;
        public int VoronoiPointSeed;
        public List<TkNoiseFlattenPoint> FlattenTerrainPoints;
        public List<float> FlattenTypeChances;
        public int WaypointIndex;
        public int LandingPadIndex;
        public float AddShelterChance;

        [NMS(Size = 3)]
        public int[] ShelterIndices;
        public int NumShelters;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4C;
    }
}
