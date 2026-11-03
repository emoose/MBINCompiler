namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDA50C203C7C2A809, NameHash = 0xC5DE593)]
    public class TkNavMeshAreaNavigability : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float EntryCost;
        [NMS(Index = 1)]
        /* 0x4 */ public float TravelCost;
        [NMS(Index = 0)]
        /* 0x8 */ public bool IsNavigable;
    }
}
