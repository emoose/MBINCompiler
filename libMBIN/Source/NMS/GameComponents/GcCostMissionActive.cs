namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24C3B305B7B06549, NameHash = 0x3F5FBC2C)]
    public class GcCostMissionActive : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A CostString;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 MissionID;
    }
}
