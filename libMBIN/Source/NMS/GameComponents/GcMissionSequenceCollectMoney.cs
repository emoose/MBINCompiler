using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9426ADEECBC83FEE, NameHash = 0x839AE0F21C2F266C)]
    public class GcMissionSequenceCollectMoney : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public int Amount;
        /* 0x084 */ public GcCurrency CollectCurrency;
        /* 0x088 */ public bool TakeAmountFromSeasonData;
        /* 0x089 */ public bool ApplyDifficultyScaling;
        /* 0x08A */ public NMSString0x80 DebugText;
        /* 0x110 */ public NMSString0x10 ForItemID;
        /* 0x120 */ public int ForItemQuantity;
        /* 0x124 */ public bool DiscountAlreadyAcquiredForItems;
    }
}
