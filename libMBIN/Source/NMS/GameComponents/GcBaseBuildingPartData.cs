using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3727BD9C84D2C7F2, NameHash = 0x4F6F7504AD1EBFFC)]
    public class GcBaseBuildingPartData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A PartID;
        /* 0x20 */ public GcBaseBuildingPartStyle Style;
        /* 0x30 */ public TkMagicModelData MagicData;
        /* 0x60 */ public uint NodesCost;
        /* 0x64 */ public uint TimeCost;
        /* 0x68 */ public uint PhysicsCost;
        /* 0x6C */ public uint MeshesCost;
        /* 0x70 */ public uint InstanceNodesCost;
        /* 0x74 */ public uint InstanceTimeCost;
        /* 0x78 */ public uint InstanceMeshesCost;
        /* 0x80 */ public ulong LastProfiledTimestamp;
        /* 0x88 */ public ulong InstanceLastProfiledTimestamp;
    }
}
