namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x800B355CD209DF1E, NameHash = 0x7E1936B219E215F)]
    public class GcMissionSequenceKillEncounter : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x20A EncounterComponentScanEvent;
        /* 0xA0 */ public bool AllowedToEscape;
        /* 0xA1 */ public NMSString0x80 DebugText;
    }
}
