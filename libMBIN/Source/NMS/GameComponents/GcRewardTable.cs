using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6723144398A8BC8, NameHash = 0x2ECD4E3663FDB26F)]
    public class GcRewardTable : NMSTemplate
    {
        /* 0x000 */ public List<GcGenericRewardTableEntry> GenericTable;
        /* 0x010 */ public List<GcGenericRewardTableEntry> DestructionTable;
        /* 0x020 */ public List<GcGenericRewardTableEntry> InteractionTable;
        /* 0x030 */ public List<GcGenericRewardTableEntry> OldInteractionTable;
        /* 0x040 */ public List<GcGenericRewardTableEntry> SpecialRewardTable;
        /* 0x050 */ public List<GcGenericRewardTableEntry> MissionBoardTable;
        /* 0x060 */ public List<GcGenericRewardTableEntry> FleetTable;
        /* 0x070 */ public List<GcGenericRewardTableEntry> WikiProgressTable;
        /* 0x080 */ public List<GcGenericRewardTableEntry> ShipSalvageTable;
        /* 0x090 */ public List<GcRewardTableEntitlementItem> EntitlementTable;
        /* 0x0A0 */ public List<GcRewardTableEntry> Table;
        /* 0x0B0 */ public List<NMSString0x10> TechRewardOrder;
        /* 0x0C0 */ public List<NMSString0x10> ProductRewardOrder;
        /* 0x0D0 */ public List<GcGenericRewardTableEntry> MixerRewardTable;
        /* 0x0E0 */ public List<GcGenericRewardTableEntry> TwitchRewardTable;
        /* 0x0F0 */ public List<GcGenericRewardTableEntry> NPCPlanetSiteTable;
        /* 0x100 */ public List<GcGenericRewardTableEntry> SettlementTable;
        /* 0x110 */ public List<GcGenericRewardTableEntry> SeasonRewardTable1;
        /* 0x120 */ public List<GcGenericRewardTableEntry> SeasonRewardTable2;
        /* 0x130 */ public List<GcGenericRewardTableEntry> SeasonRewardTable3;
        /* 0x140 */ public List<GcGenericRewardTableEntry> SeasonRewardTable4;
        /* 0x150 */ public List<GcGenericRewardTableEntry> SeasonRewardTable5;
        /* 0x160 */ public List<GcGenericRewardTableEntry> SeasonRewardTable6;
        /* 0x170 */ public List<GcGenericRewardTableEntry> SeasonRewardTable7;
        /* 0x180 */ public List<GcGenericRewardTableEntry> SeasonRewardTable8;
        /* 0x190 */ public List<GcGenericRewardTableEntry> SeasonRewardTable9;
        /* 0x1A0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable10;
        /* 0x1B0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable11;
        /* 0x1C0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable12;
        /* 0x1D0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable13;
        /* 0x1E0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable14;
        /* 0x1F0 */ public List<GcGenericRewardTableEntry> SeasonRewardTable15;
        /* 0x200 */ public List<GcGenericRewardTableEntry> SeasonRewardTable16;
    }
}
