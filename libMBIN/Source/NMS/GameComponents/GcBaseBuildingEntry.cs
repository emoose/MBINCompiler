using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x73BBAC671634F9F7, NameHash = 0xA6F7B710166F6076)]
    public class GcBaseBuildingEntry : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ID;
        /* 0x010 */ public bool IsTemporary;
        /* 0x011 */ public bool IsFromModFolder;
        /* 0x014 */ public GcBaseBuildingPartStyle Style;
        /* 0x018 */ public TkModelResource PlacementScene;
        /* 0x0A0 */ public NMSString0x20A SinglePartID;
        /* 0x0C0 */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        /* 0x0C4 */ public bool IsPlaceable;
        /* 0x0C5 */ public bool IsDecoration;
        /* 0x0C8 */ public GcBiomeType Biome;
        /* 0x0CC */ public bool BuildableOnPlanetBase;
        /* 0x0CD */ public bool BuildableOnSpaceBase;
        /* 0x0CE */ public bool BuildableOnFreighter;
        /* 0x0CF */ public bool BuildableOnPlanet;
        /* 0x0D0 */ public bool BuildableOnPlanetWithProduct;
        /* 0x0D1 */ public bool BuildableUnderwater;
        /* 0x0D2 */ public bool BuildableAboveWater;
        /* 0x0D4 */ public int PlanetLimit;
        /* 0x0D8 */ public int RegionLimit;
        /* 0x0DC */ public int PlanetBaseLimit;
        /* 0x0E0 */ public int FreighterBaseLimit;
        /* 0x0E4 */ public bool CheckPlaceholderCollision;
        /* 0x0E5 */ public bool CheckPlayerCollision;
        /* 0x0E6 */ public bool CanRotate3D;
        /* 0x0E7 */ public bool CanScale;
        /* 0x0E8 */ public List<GcBaseBuildingEntryGroup> Groups;
        /* 0x0F8 */ public int StorageContainerIndex;
        /* 0x100 */ public NMSString0x20A ColourPaletteGroupId;
        /* 0x120 */ public NMSString0x20A DefaultColourPaletteId;
        /* 0x140 */ public NMSString0x20A MaterialGroupId;
        /* 0x160 */ public NMSString0x20A DefaultMaterialId;
        /* 0x180 */ public bool CanChangeColour;
        /* 0x181 */ public bool CanChangeMaterial;
        /* 0x182 */ public bool CanPickUp;
        /* 0x183 */ public bool ShowInBuildMenu;
        /* 0x188 */ public List<NMSString0x10> CompositePartObjectIDs;
        /* 0x198 */ public List<NMSString0x10> FamilyIDs;
        /* 0x1A8 */ public float BuildEffectAccelerator;
        /* 0x1AC */ public bool RemovesAttachedDecoration;
        /* 0x1AD */ public bool RemovesWhenUnsnapped;
        /* 0x1AE */ public bool EditsTerrain;
        // size: 0x2
        public enum BaseTerrainEditShapeEnum : uint {
            Cube,
            Cylinder,
        }
        /* 0x1B0 */ public BaseTerrainEditShapeEnum BaseTerrainEditShape;
        /* 0x1B4 */ public float MinimumDeleteDistance;
        /* 0x1B8 */ public bool IsSealed;
        /* 0x1B9 */ public bool CloseMenuAfterBuild;
        /* 0x1C0 */ public GcBaseLinkGridData LinkGridData;
        /* 0x218 */ public int GhostsCountOverride;
        /* 0x21C */ public bool ShowGhosts;
        /* 0x220 */ public float SnappingDistanceOverride;
        /* 0x224 */ public int RegionSpawnLOD;
        /* 0x228 */ public TkModelResource NPCInteractionScene;
    }
}
