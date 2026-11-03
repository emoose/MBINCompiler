namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA54631F958D88E30, NameHash = 0x58A5B69E)]
    public class GcPortalSaveData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcSeed PortalSeed;
        [NMS(Index = 1)]
        /* 0x10 */ public ulong LastPortalUA;
        [NMS(Index = 2)]
        /* 0x18 */ public bool IsStoryPortal;
    }
}
