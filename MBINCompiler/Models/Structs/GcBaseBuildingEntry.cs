using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcBaseBuildingEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string ID;
        /* 0x010 */ public TkModelResource Model;
        /* 0x094 */ public GcBaseBuildingObjectTypes Type;
        /* 0x098 */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        /* 0x09C */ public GcBiomeType Biome;

        /* 0x0A0 */ public bool BuildableOnBase;
        /* 0x0A1 */ public bool BuildableOnFreighter;
        /* 0x0A2 */ public bool BuildableOnPlanet;
        // 1 byte padding?
        /* 0x0A4 */ public int GlobalLimit;
        /* 0x0A8 */ public int SystemLimit;
        /* 0x0AC */ public int PlanetLimit;
        /* 0x0B0 */ public int RegionLimit;

        [NMS(Size = 3, Ignore = false)]
        /* 0x0B4 */ public int[] PerBaseLimits;
        /* 0x0C0 */ public float CollisionRadiusFactor;
        /* 0x0C4 */ public bool CheckCollision;
        /* 0x0C5 */ public bool CollidesWithPlayer;
        /* 0x0C6 */ public bool CanPlaceOnItself;
        [NMS(Size = 1, Ignore = true)]
        /* 0x0C7 */ public byte[] PaddingC3;

        [NMS(Size = 0x10)]
        /* 0x0C8 */ public string Group;

        /* 0x0D8 */
        public bool DontStore;
        [NMS(Size = 3, Ignore = true)]
        /* 0x0D9 */ public byte[] PaddingD9;
        /* 0x0DC */ public float CameraRotDeg;
        /* 0x0E0 */ public int ComplexityCost;
        /* 0x0E4 */ public int ForceExtraIdx;
        /* 0x0E8 */ public int SnappingLimit;
        /* 0x0EC */ public int GroupSnappingLimit;
        [NMS(Size = 0x20)]
        /* 0x0F0 */ public string Hint;
        /* 0x110 */ public bool RemoveGrass;
        /* 0x111 */ public bool RemoveIfNoNeighbours;
        /* 0x112 */ public bool ForceCheckPlayerInside;

        /* 0x114 */ public float PlayerInsideRadiusFactor;
        /* 0x118 */ public bool CanChangeColour;
        /* 0x119 */ public bool CanChangeMaterial;


        [NMS(Size = 6, Ignore = true)]
        /* 0x120 */ public byte[] Padding120;
    }
}
