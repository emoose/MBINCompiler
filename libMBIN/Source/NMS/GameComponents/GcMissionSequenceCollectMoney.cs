using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10C, GUID = 0x0, NameHash = 0x839AE0F21C2F266C)]
    public class GcMissionSequenceCollectMoney : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public int Amount;
		/* 0x084 */ public GcCurrency CollectCurrency;
        /* 0x088 */ public bool TakeAmountFromSeasonData;
        [NMS(Size = 0x80)]
        /* 0x089 */ public string DebugText;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x109 */ public byte[] EndPadding;
    }
}
