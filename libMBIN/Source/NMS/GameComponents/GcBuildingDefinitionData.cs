using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4C79967AF81939E, NameHash = 0x15C14AC1)]
    public class GcBuildingDefinitionData : NMSTemplate
    {
        [NMS(Index = 16)]
        /* 0x00 */ public Vector3f AABBOverrideMax;
        [NMS(Index = 15)]
        /* 0x10 */ public Vector3f AABBOverrideMin;
        [NMS(Index = 8)]
        /* 0x20 */ public NMSString0x20A TextureNameHint;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x10 ClusterLayout;
        [NMS(Index = 3, Size = 0x8, EnumType = typeof(GcBuildingDensityLevels.BuildingDensityEnum))]
        /* 0x50 */ public float[] Density;
        [NMS(Index = 0)]
        /* 0x70 */ public TkNoiseFlattenOptions FlattenType;
        [NMS(Index = 2)]
        /* 0x78 */ public float ClusterSpacing;
        [NMS(Index = 12)]
        /* 0x7C */ public float MaxHeight;
        [NMS(Index = 11)]
        /* 0x80 */ public float MinHeight;
        [NMS(Index = 7)]
        /* 0x84 */ public int NumModelsToGenerate;
        [NMS(Index = 5)]
        /* 0x88 */ public int NumOverridesToGenerate;
        [NMS(Index = 6)]
        /* 0x8C */ public int NumOverridesToGenerateWaterworlds;
        [NMS(Index = 9, MxmlName = "OverrideRadius ")]
        /* 0x90 */ public float OverrideRadius;
        [NMS(Index = 13)]
        /* 0x94 */ public GcPlanetaryBuildingRestrictions PlanetRestrictions;
        [NMS(Index = 4)]
        /* 0x98 */ public bool EnabledWhenPlanetHasNoNPCs;
        [NMS(Index = 10)]
        /* 0x99 */ public bool GivesShelter;
        [NMS(Index = 14)]
        /* 0x9A */ public bool IgnoreParticlesInAABB;
    }
}
