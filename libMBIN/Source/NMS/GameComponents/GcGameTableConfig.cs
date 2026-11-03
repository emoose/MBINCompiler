namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x114720A1D60C2D02, NameHash = 0x265CD766)]
    public class GcGameTableConfig : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A GameConfigId;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20A Id;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x20A SpawnDataId;
    }
}
