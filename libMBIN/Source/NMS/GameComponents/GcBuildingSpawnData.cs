using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x600, GUID = 0x2F9F6DE29A3DE97E, NameHash = 0x2FE28DE7841506AF)]
    public class GcBuildingSpawnData : NMSTemplate
    {
        /* 0x000 */ public float Density;
        /* 0x008 */ public GcResourceElement Resource;
        /* 0x2B0 */ public GcResourceElement UnderwaterResource;
        /* 0x558 */ public int LSystemID;
        /* 0x55C */ public int UnderwaterLSystemID;
        /* 0x560 */ public int WFCModuleSet;
        /* 0x564 */ public int UnderwaterWFCModuleSet;
        /* 0x568 */ public int WFCBuildingPreset;
        /* 0x56C */ public bool AutoCollision;
        /* 0x570 */ public GcSeed Seed;
        /* 0x580 */ public GcBuildingClassification Classification;
        [NMS(Size = 0x8)]
        /* 0x584 */ public int[] ClusterLayouts;
        /* 0x5A4 */ public int ClusterLayoutCount;
        /* 0x5A8 */ public float ClusterSpacing;
        /* 0x5AC */ public TkNoiseFlattenOptions FlattenType;
        /* 0x5B4 */ public bool GivesShelter;
        /* 0x5B5 */ public bool AlignToNormal;
        /* 0x5B6 */ public bool LowerIntoGround;
        /* 0x5B8 */ public float Scale;
        /* 0x5BC */ public float MaxXZRotation;
        /* 0x5C0 */ public float Radius;
        /* 0x5C4 */ public float MinHeight;
        /* 0x5C8 */ public float Maxheight;
        /* 0x5CC */ public int InstanceID;
        /* 0x5D0 */ public Vector3f AABBMin;
        /* 0x5E0 */ public Vector3f AABBMax;
        /* 0x5F0 */ public bool BuildingSizeCalculated;
    }
}
