using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x400, GUID = 0xC0727D4F8D3CB6F6, NameHash = 0xA6F7B710166F6076)]
    public class GcBaseBuildingEntry : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ID;
        /* 0x010 */ public bool HasProduct;
        /* 0x011 */ public bool IsTemporary;
        /* 0x012 */ public bool IsFromModFolder;
        /* 0x014 */ public GcBaseBuildingPartStyle Style;
        /* 0x018 */ public TkModelResource PlacementScene;
        /* 0x09C */ public TkModelResource SnapPoints;
        /* 0x120 */ public TkModelResource Model;
        /* 0x1A4 */ public TkModelResource InactiveModel;
        /* 0x228 */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        /* 0x22C */ public bool IsPlaceable;
        /* 0x22D */ public bool IsDecoration;
        /* 0x230 */ public float PlacementNormalOffset;
        /* 0x234 */ public GcBiomeType Biome;
        /* 0x238 */ public bool BuildableOnPlanetBase;
        /* 0x239 */ public bool BuildableOnSpaceBase;
        /* 0x23A */ public bool BuildableOnFreighter;
        /* 0x23B */ public bool BuildableOnPlanet;
        /* 0x23C */ public bool BuildableOnPlanetWithProduct;
        /* 0x23D */ public bool BuildableUnderwater;
        /* 0x23E */ public bool BuildableAboveWater;
        /* 0x240 */ public int PlanetLimit;
        /* 0x244 */ public int RegionLimit;
        /* 0x248 */ public int PlanetBaseLimit;
        /* 0x24C */ public int FreighterBaseLimit;
        /* 0x250 */ public bool CheckPlaceholderCollision;
        /* 0x254 */ public float CollisionScale;
        /* 0x258 */ public bool EnableCollision;
        /* 0x259 */ public bool OptionalPhysics;
        /* 0x25A */ public bool CanPlaceOnItself;
        /* 0x25B */ public bool CanRotate3D;
        /* 0x25C */ public bool CanScale;
        /* 0x260 */ public List<GcBaseBuildingEntryGroup> Groups;
        /* 0x270 */ public int StorageContainerIndex;
        /* 0x278 */ public NMSString0x20A ColourPaletteGroupId;
        /* 0x298 */ public NMSString0x20A DefaultColourPaletteId;
        /* 0x2B8 */ public NMSString0x20A MaterialGroupId;
        /* 0x2D8 */ public NMSString0x20A DefaultMaterialId;
        /* 0x2F8 */ public bool CanChangeColour;
        /* 0x2F9 */ public bool CanChangeMaterial;
        /* 0x2FA */ public bool CanPickUp;
        /* 0x2FC */ public float ScanRadius;
        /* 0x300 */ public bool RemovesAttachedDecoration;
        /* 0x301 */ public bool EditsTerrain;
        public enum BaseTerrainEditShapeEnum { Cube, Cylinder }
        /* 0x304 */ public BaseTerrainEditShapeEnum BaseTerrainEditShape;
        /* 0x308 */ public float TerrainEditBaseYOffset;
        /* 0x30C */ public float TerrainEditTopYOffset;
        /* 0x310 */ public float TerrainEditBoundsScalar;
        /* 0x314 */ public bool IsSealed;
        /* 0x315 */ public bool CloseMenuAfterBuild;
        /* 0x318 */ public GcBaseLinkGridData LinkGridData;
        /* 0x370 */ public int GhostsCountOverride;
        /* 0x374 */ public float SnappingDistanceOverride;
        /* 0x378 */ public int RegionSpawnLOD;
        /* 0x37C */ public TkModelResource NPCInteractionScene;
    }
}
