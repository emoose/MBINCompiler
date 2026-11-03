using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C16B5CD20A2A8F2, NameHash = 0xD9A70698)]
    public class GcDroneDataWithId : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcDroneData Data;
        [NMS(Index = 0)]
        /* 0x440 */ public NMSString0x10 Id;
    }
}
