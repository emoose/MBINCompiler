using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x278, GUID = 0xB9BCACA4DB13794C, NameHash = 0xA6F7B710166F6076)]
    public class GcBaseBuildingEntry : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ID;
        /* 0x010 */ public bool HasProduct;
        /* 0x011 */ public bool IsTemporary;
        /* 0x012 */ public bool IsFromModFolder;
        /* 0x014 */ public GcBaseBuildingPartStyle Style;
        /* 0x018 */ public TkModelResource PlacementScene;
        /* 0x09C */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        /* 0x0A0 */ public bool IsPlaceable;
        /* 0x0A1 */ public bool IsDecoration;
        /* 0x0A4 */ public float PlacementNormalOffset;
        /* 0x0A8 */ public GcBiomeType Biome;
        /* 0x0AC */ public bool BuildableOnPlanetBase;
        /* 0x0AD */ public bool BuildableOnSpaceBase;
        /* 0x0AE */ public bool BuildableOnFreighter;
        /* 0x0AF */ public bool BuildableOnPlanet;
        /* 0x0B0 */ public bool BuildableOnPlanetWithProduct;
        /* 0x0B1 */ public bool BuildableUnderwater;
        /* 0x0B2 */ public bool BuildableAboveWater;
        /* 0x0B4 */ public int PlanetLimit;
        /* 0x0B8 */ public int RegionLimit;
        /* 0x0BC */ public int PlanetBaseLimit;
        /* 0x0C0 */ public int FreighterBaseLimit;
        /* 0x0C4 */ public bool CheckPlaceholderCollision;
        /* 0x0C5 */ public bool EnableCollision;
        /* 0x0C6 */ public bool OptionalPhysics;
        /* 0x0C7 */ public bool CanPlaceOnItself;
        /* 0x0C8 */ public bool CanRotate3D;
        /* 0x0C9 */ public bool CanScale;
        /* 0x0D0 */ public List<GcBaseBuildingEntryGroup> Groups;
        /* 0x0E0 */ public int StorageContainerIndex;
        /* 0x0E8 */ public NMSString0x20A ColourPaletteGroupId;
        /* 0x108 */ public NMSString0x20A DefaultColourPaletteId;
        /* 0x128 */ public NMSString0x20A MaterialGroupId;
        /* 0x148 */ public NMSString0x20A DefaultMaterialId;
        /* 0x168 */ public bool CanChangeColour;
        /* 0x169 */ public bool CanChangeMaterial;
        /* 0x16A */ public bool CanPickUp;
        /* 0x16B */ public bool ShowInBuildMenu;
        /* 0x170 */ public List<NMSString0x10> CompositePartObjectIDs;
        /* 0x180 */ public bool RemovesAttachedDecoration;
        /* 0x181 */ public bool EditsTerrain;
        public enum BaseTerrainEditShapeEnum { Cube, Cylinder }
        /* 0x184 */ public BaseTerrainEditShapeEnum BaseTerrainEditShape;
        /* 0x188 */ public bool IsSealed;
        /* 0x189 */ public bool CloseMenuAfterBuild;
        /* 0x190 */ public GcBaseLinkGridData LinkGridData;
        /* 0x1E8 */ public int GhostsCountOverride;
        /* 0x1EC */ public float SnappingDistanceOverride;
        /* 0x1F0 */ public int RegionSpawnLOD;
        /* 0x1F4 */ public TkModelResource NPCInteractionScene;
    }
}
