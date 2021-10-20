using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x140, GUID = 0x46CF52B7ECF6568A, NameHash = 0x84D6228673F661A6)]
    public class GcMissionSequenceCollectSubstance : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcDefaultMissionSubstanceEnum Default;
        /* 0x84 */ public GcSubstanceTableEnum Substance;
        /* 0x88 */ public int AmountMin;
        /* 0x8C */ public int AmountMax;
        /* 0x90 */ public bool WaitForSelected;
        /* 0x98 */ public NMSString0x10 ForBuild;
        /* 0xA8 */ public NMSString0x10 ForRepair;
        /* 0xB8 */ public bool FromNow;
        /* 0xB9 */ public bool TakeAmountFromSeasonData;
        /* 0xBA */ public NMSString0x80 DebugText;
    }
}
