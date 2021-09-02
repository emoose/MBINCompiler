using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x78, GUID = 0x818C955087AC596F, NameHash = 0x59A43238181BB69F)]
    public class GcBuildingDefinitionData : NMSTemplate
    {
        /* 0x00 */ public TkNoiseFlattenOptions FlattenType;
        /* 0x08 */ public GcBuildingClusterPlacement Placement;
        /* 0x10 */ public NMSString0x10 ClusterLayout;
        /* 0x20 */ public float ClusterSpacing;
        [NMS(Size = 0x6, EnumType = typeof(GcBuildingDensityLevels.BuildingDensityEnum))]
        /* 0x24 */ public float[] Density;
        /* 0x3C */ public bool EnabledWhenPlanetHasNoNPCs;
        /* 0x40 */ public int NumOverridesToGenerate;
        /* 0x44 */ public int NumModelsToGenerate;
        /* 0x48 */ public NMSString0x20A TextureNameHint;
        /* 0x68 */ public float OverrideRadius;
        /* 0x6C */ public bool GivesShelter;
        /* 0x70 */ public float MinHeight;
        /* 0x74 */ public float MaxHeight;
    }
}
