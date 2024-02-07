using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF25C35AE0519CFB, NameHash = 0x88DEFBD52206A298)]
    public class GcMissionSequenceWaitForShips : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 MessageLowShield;
        /* 0x100 */ public GcRealityCommonFactions Type;
        /* 0x104 */ public int Count;
        /* 0x108 */ public NMSString0x80 DebugText;
    }
}
