using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x220, GUID = 0xAB745621068EB93B)]
    public class GcBaseBuildingEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string ID;
        /* 0x010 */ public bool HasProduct;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x011 */ public byte[] Padding11;
        /* 0x014 */ public TkModelResource SnapPoints;
        /* 0x098 */ public TkModelResource Model;
        /* 0x11C */ public TkModelResource InactiveModel;
        /* 0x1A0 */ public GcBaseBuildingObjectTypes Type;
        /* 0x1A4 */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        /* 0x1A8 */ public GcBiomeType Biome;
        /* 0x1AC */ public int RegionSpawnLOD;

        /* 0x1B0 */ public bool BuildableOnBase;
        /* 0x1B1 */ public bool BuildableOnFreighter;
        /* 0x1B2 */ public bool BuildableOnPlanet;
        /* 0x1B3 */ public bool BuildableUnderwater;
        /* 0x1B4 */ public bool BuildableAboveWater;

        /* 0x1B8 */ public int GlobalLimit;
        /* 0x1BC */ public int SystemLimit;
        /* 0x1C0 */ public int PlanetLimit;
        /* 0x1C4 */ public int RegionLimit;
        /* 0x1C8 */ public int PlanetBaseLimit;
        /* 0x1CC */ public int FreighterBaseLimit;
        /* 0x1D0 */ public float BaseLayoutRadius;
        /* 0x1D4 */ public bool CheckCollision;
        /* 0x1D8 */ public float CollisionScale;
        /* 0x1DC */ public bool CollidesWithPlayer;
        /* 0x1DD */ public bool CanPlaceOnItself;
        [NMS(Size = 2, Ignore = true)]
        /* 0x1DE */ public byte[] Padding1DE;

        [NMS(Size = 0x10)]
        /* 0x1E0 */ public string Group;

        /* 0x1F0 */ public int ComplexityCost;
        /* 0x1F4 */ public int InactiveComplexityCost;
        /* 0x1F8 */ public int ForceExtraIdx;
        /* 0x1FC */ public int GroupSnappingLimit;
        /* 0x200 */ public bool CanChangeColour;
        /* 0x201 */ public bool CanChangeMaterial;
        /* 0x202 */ public bool CanPickUp;
        /* 0x204 */ public float ScanRadius;
        /* 0x208 */ public bool RemovesAttachedDecoration;
        /* 0x209 */ public bool EditsTerrain;

		public enum BaseTerrainEditShapeEnum { Cube, Cylinder }
		/* 0x20C */ public BaseTerrainEditShapeEnum BaseTerrainEditShape;

        /* 0x210 */ public float TerrainEditBaseYOffset;
        /* 0x214 */ public float TerrainEditTopYOffset;
        /* 0x218 */ public float TerrainEditBoundsScalar;
        /* 0x21C */ public bool IsSealed;
        /* 0x21D */ public bool CloseMenuAfterBuild;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x21E */ public byte[] EndPadding;
    }
}
