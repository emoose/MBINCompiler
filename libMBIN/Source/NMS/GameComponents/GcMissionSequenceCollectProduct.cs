using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x140, GUID = 0xF717E224BB9AD7D2, NameHash = 0x139E6194371FE10E)]
    public class GcMissionSequenceCollectProduct : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public GcDefaultMissionProductEnum Default;
        /* 0x084 */ public GcProductTableEnum Product;
        /* 0x088 */ public int AmountMin;
        /* 0x08C */ public int AmountMax;
        /* 0x090 */ public bool WaitForSelected;
        /* 0x098 */ public NMSString0x10 ForBuild;
        /* 0x0A8 */ public NMSString0x10 ForRepair;
        /* 0x0B8 */ public bool TeachIfNotKnown;
        /* 0x0B9 */ public bool FromNow;
        /* 0x0BA */ public NMSString0x80 DebugText;
    }
}
