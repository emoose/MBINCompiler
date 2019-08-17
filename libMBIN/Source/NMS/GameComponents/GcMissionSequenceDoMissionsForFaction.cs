using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7201A77CBA1AD625, SubGUID = 0xBDA9289A7DF468BD)]
    public class GcMissionSequenceDoMissionsForFaction : NMSTemplate      // size: 0x110
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string MessageGetToSpace;
        /* 0x080 */ public GcFactionSelectOptions SelectFrom;

        /* 0x088 */ public int AmountMine;
        /* 0x08C */ public int AmountMax;
        [NMS(Size = 0x80)]
        /* 0x190 */ public string DebugText;
    }
}
