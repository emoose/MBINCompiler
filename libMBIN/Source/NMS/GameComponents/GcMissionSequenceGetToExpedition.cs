namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF744E48C58955C7, NameHash = 0xB3C5F69D62F6CA73)]
    public class GcMissionSequenceGetToExpedition : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 GalaxyMapMessage;
        /* 0x100 */ public NMSString0x20A Event;
        /* 0x120 */ public float CompletionDistance;
        /* 0x124 */ public NMSString0x80 DebugText;
    }
}
