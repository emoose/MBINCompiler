namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D76EB9D173DAF45, NameHash = 0xC83C0D1)]
    public class GcItemDescriptionOverride : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A NewDescription;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 ItemID;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x10 MissionID;
    }
}
