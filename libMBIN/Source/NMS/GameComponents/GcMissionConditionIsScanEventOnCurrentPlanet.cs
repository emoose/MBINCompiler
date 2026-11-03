namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFAC1DC59462A06B8, NameHash = 0x611ABB28)]
    public class GcMissionConditionIsScanEventOnCurrentPlanet : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 1)]
        /* 0x20 */ public bool AllowInShip;
    }
}
