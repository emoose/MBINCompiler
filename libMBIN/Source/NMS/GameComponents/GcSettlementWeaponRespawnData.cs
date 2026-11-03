namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD360BAD746E950D, NameHash = 0x6959C018)]
    public class GcSettlementWeaponRespawnData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public ulong InteractionSeed;
        [NMS(Index = 1)]
        /* 0x8 */ public ulong LastWeaponRefreshTimestamp;
    }
}
