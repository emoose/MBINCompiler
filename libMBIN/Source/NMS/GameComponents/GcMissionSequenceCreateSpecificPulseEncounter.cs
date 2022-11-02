namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5BF35F84A3F4CF47, NameHash = 0x245D62E60DEB8B1E)]
    public class GcMissionSequenceCreateSpecificPulseEncounter : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 MessageNoShip;
        /* 0x100 */ public NMSString0x80 MessageNotPulsing;
        /* 0x180 */ public NMSString0x80 MessageSignalBlocked;
        /* 0x200 */ public float MinTimeInPulse;
        /* 0x208 */ public NMSString0x10 PulseEncounterID;
        /* 0x218 */ public bool AllowAnyEncounter;
        /* 0x219 */ public bool Silent;
        /* 0x21A */ public NMSString0x80 DebugText;
    }
}
