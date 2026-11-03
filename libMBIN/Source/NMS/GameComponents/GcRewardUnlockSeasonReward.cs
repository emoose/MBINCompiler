namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x25F69EA6949D2DE0, NameHash = 0x3946E451)]
    public class GcRewardUnlockSeasonReward : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A EncryptedText;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 ProductID;
        [NMS(Index = 4)]
        /* 0x30 */ public bool MarkAsClaimedInShop;
        [NMS(Index = 1)]
        /* 0x31 */ public bool Silent;
        [NMS(Index = 5)]
        /* 0x32 */ public bool UniqueInventoryItem;
        [NMS(Index = 3)]
        /* 0x33 */ public bool UseSpecialFormatting;
    }
}
