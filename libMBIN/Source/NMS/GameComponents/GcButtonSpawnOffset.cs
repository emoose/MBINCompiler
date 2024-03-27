using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x31748E19E8D4B7B8, NameHash = 0x42A6687A1AF1F42A)]
    public class GcButtonSpawnOffset : NMSTemplate
    {
        /* 0x00 */ public float AngleMin;
        /* 0x04 */ public float AngleMax;
        /* 0x08 */ public float Offset;
        /* 0x0C */ public float Spacing;
        /* 0x10 */ public float Facing;
        /* 0x14 */ public int Count;
        /* 0x18 */ public GcRealityCommonFactions Faction;
        /* 0x1C */ public GcAISpaceshipRoles ShipRole;
    }
}
