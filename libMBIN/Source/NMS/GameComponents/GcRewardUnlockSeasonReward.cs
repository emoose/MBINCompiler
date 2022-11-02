namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9879C222BC362663, NameHash = 0x7AB9EBA17278DE9B)]
    public class GcRewardUnlockSeasonReward : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ProductID;
        /* 0x10 */ public bool Silent;
        /* 0x18 */ public NMSString0x20A EncryptedText;
        /* 0x38 */ public bool UseSpecialFormatting;
        /* 0x39 */ public bool MarkAsClaimedInShop;
    }
}
