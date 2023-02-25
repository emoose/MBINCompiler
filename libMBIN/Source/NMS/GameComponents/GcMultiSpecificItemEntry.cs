using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE83D9C2444D3380, NameHash = 0x7439D28A897F0ACC)]
    public class GcMultiSpecificItemEntry : NMSTemplate
    {
        // size: 0x6
        public enum MultiItemRewardTypeEnum : uint {
            Product,
            Substance,
            ProcTech,
            ProcProduct,
            InventorySlot,
            CommunityTierProduct,
        }
        /* 0x00 */ public MultiItemRewardTypeEnum MultiItemRewardType;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public int Amount;
        /* 0x20 */ public NMSString0x20A ProcTechGroup;
        /* 0x40 */ public int ProcTechQuality;
        /* 0x44 */ public bool IllegalProcTech;
        /* 0x45 */ public bool SentinelProcTech;
        /* 0x46 */ public bool AlsoTeachTechBoxRecipe;
        /* 0x48 */ public GcProceduralProductCategory ProcProdType;
        /* 0x4C */ public GcRarity ProcProdRarity;
        /* 0x50 */ public List<NMSString0x10> CommunityTierProductList;
        /* 0x60 */ public bool HideInSeasonRewards;
        /* 0x68 */ public NMSString0x10 SeasonRewardListFormat;
        /* 0x78 */ public NMSString0x20A CustomRewardLocID;
    }
}
