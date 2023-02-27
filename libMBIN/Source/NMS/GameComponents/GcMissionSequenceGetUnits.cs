namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B06EC7C0037A048, NameHash = 0x785DA5C6069D4C12)]
    public class GcMissionSequenceGetUnits : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public int Amount;
        /* 0x84 */ public NMSString0x80 DebugText;
    }
}
