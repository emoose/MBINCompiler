namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xB58)]
    public class GcGalaxyInfoIcons : NMSTemplate
    {
        [NMS(Size = 0x7, EnumValue = new[] { "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomats", "None" })]
        /* 0x000 */ public TkTextureResource[] RaceIcons;
        [NMS(Size = 0x7, EnumValue = new[] { "Mining", "HighTech", "Trading", "Manufacturing", "Fusion", "Scientific", "PowerGeneration" })]
        /* 0x39C */ public TkTextureResource[] EconomyIcons;
        /* 0x738 */ public TkTextureResource EconomyTechNotInstalledIcon;
        [NMS(Size = 0x3, EnumValue = new[] { "Low", "Default", "High" })]
        /* 0x7BC */ public TkTextureResource[] ConflictIcons;
        /* 0x948 */ public TkTextureResource ConflictTechNotInstalledIcon;
        /* 0x9CC */ public TkTextureResource Warpicon;
        /* 0xA50 */ public TkTextureResource WarpErrorIcon;
        /* 0xAD4 */ public TkTextureResource WarpTechNotInstalledIcon;
    }
}
