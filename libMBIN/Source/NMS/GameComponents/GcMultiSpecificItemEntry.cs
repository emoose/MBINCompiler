using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x50, GUID = 0x6E82F26909906DB0, NameHash = 0x7439D28A897F0ACC)]
    public class GcMultiSpecificItemEntry : NMSTemplate
    {
        public enum MultiItemRewardTypeEnum { Product, Substance, ProcTech, ProcProduct, InventorySlot }
        /* 0x00 */ public MultiItemRewardTypeEnum MultiItemRewardType;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Id;
        /* 0x18 */ public int Amount;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1C */ public byte[] Padding1C;
        [NMS(Size = 0x20)]
        /* 0x20 */ public string ProcTechGroup;
        /* 0x40 */ public int ProcTechQuality;
        /* 0x44 */ public GcProceduralProductCategory ProcProdType;
        /* 0x48 */ public GcRarity ProcProdRarity;
        /* 0x4C */ public bool HideInSeasonRewards;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x4D */ public byte[] EndPadding;

    }
}
