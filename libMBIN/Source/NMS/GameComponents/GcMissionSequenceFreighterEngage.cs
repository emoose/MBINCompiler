namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x58BA8A8354A7C52B, NameHash = 0x5755416737105B76)]
    public class GcMissionSequenceFreighterEngage : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 MessageGetToSpace;
        /* 0x080 */ public NMSString0x80 MessageEngage;
        /* 0x100 */ public float EngageDistance;
        /* 0x104 */ public float EngageTime;
        /* 0x108 */ public float TimeAfterWarp;
        /* 0x110 */ public NMSString0x10 TimeoutMessage;
        /* 0x120 */ public NMSString0x80 TimeoutOSDMessage;
        /* 0x1A0 */ public NMSString0x80 DebugText;
    }
}
