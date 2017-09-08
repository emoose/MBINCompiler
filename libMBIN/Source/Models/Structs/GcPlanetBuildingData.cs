using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x60)]
    public class GcPlanetBuildingData : NMSTemplate
    {
        /* 0x00 */ public List<GcBuildingSpawnData> Buildings;
        /* 0x10 */ public List<GcBuildingOverrideData> OverrideBuildings;
        /* 0x20 */ public float Spacing;
        /* 0x24 */ public float PlanetRadius;
        /* 0x28 */ public float VoronoiPointDivisions;
        /* 0x2C */ public int VoronoiSectorSeed;
        /* 0x30 */ public int VoronoiPointSeed;
        [NMS(Size = 0x4)]
        /* 0x34 */ public float[] ClusterProbability;
        /* 0x44 */ public int WaypointIndex;
        /* 0x48 */ public int LandingPadIndex;
        /* 0x4C */ public float AddShelterChance;
        [NMS(Size = 0x3)]
        /* 0x50 */ public int[] ShelterIndices;
        /* 0x5C */ public int NumShelters;
    }
}
