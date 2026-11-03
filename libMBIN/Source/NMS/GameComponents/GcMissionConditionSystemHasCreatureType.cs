namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA4E23E018904E48, NameHash = 0xCBF48450)]
    public class GcMissionConditionSystemHasCreatureType : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 CreatureID;
        [NMS(Index = 2)]
        /* 0x10 */ public bool AllowInNexus;
        [NMS(Index = 1)]
        /* 0x11 */ public bool RequireOnPlanet;
    }
}
