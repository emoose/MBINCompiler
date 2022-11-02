using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2A8F3E470564A03, NameHash = 0x88DEFBD52206A298)]
    public class GcMissionSequenceWaitForShips : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcRealityCommonFactions Type;
        /* 0x84 */ public int Count;
        /* 0x88 */ public NMSString0x80 DebugText;
    }
}
