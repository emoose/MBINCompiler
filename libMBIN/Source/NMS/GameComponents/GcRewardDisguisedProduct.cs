using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87720DEB48C82097, NameHash = 0xDBFECF3462D8A0FB)]
    public class GcRewardDisguisedProduct : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionProductEnum Default;
        /* 0x08 */ public NMSString0x10 ID;
        /* 0x18 */ public NMSString0x10 DisplayAs;
        /* 0x28 */ public NMSString0x10 AwardDisplayIDDuringMission;
        /* 0x38 */ public bool UseDisplayIDWhenInShip;
        /* 0x3C */ public int AmountMin;
        /* 0x40 */ public int AmountMax;
    }
}
