namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE843341DC899B7F2, NameHash = 0x985FA68F)]
    public class GcMissionConditionCanMakeFossil : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float NearbyDisplayDistance;
        [NMS(Index = 0)]
        /* 0x4 */ public bool ConsiderItemsInNearbyDisplays;
    }
}
