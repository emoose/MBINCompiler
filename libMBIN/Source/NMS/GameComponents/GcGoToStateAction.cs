using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A2B3C0BE72D1702, NameHash = 0xBEE7641A87849DA4)]
    public class GcGoToStateAction : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 State;
        /* 0x10 */ public bool Broadcast;
        /* 0x14 */ public GcBroadcastLevel BroadcastLevel;
    }
}
