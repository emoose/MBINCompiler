using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C6BB77CC0F3C9A1, NameHash = 0x1DE42844C3529A0B)]
    public class GcGalaxyInfoIcons : NMSTemplate
    {
        // size: 0x8
        public enum RaceIconsEnum {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None
        }
        [NMS(Size = 0x8, EnumType = typeof(RaceIconsEnum))]
        /* 0x000 */ public TkTextureResource[] RaceIcons;
        // size: 0x7
        public enum EconomyIconsEnum {
            Mining,
            HighTech,
            Trading,
            Manufacturing,
            Fusion,
            Scientific,
            PowerGeneration
        }
        [NMS(Size = 0x7, EnumType = typeof(EconomyIconsEnum))]
        /* 0x420 */ public TkTextureResource[] EconomyIcons;
        /* 0x7BC */ public TkTextureResource EconomyTechNotInstalledIcon;
        // size: 0x4
        public enum WealthIconsEnum {
            Poor,
            Average,
            Wealthy,
            Pirate
        }
        [NMS(Size = 0x4, EnumType = typeof(WealthIconsEnum))]
        /* 0x840 */ public TkTextureResource[] WealthIcons;
        // size: 0x4
        public enum ConflictIconsEnum {
            Low,
            Default,
            High,
            Pirate
        }
        [NMS(Size = 0x4, EnumType = typeof(ConflictIconsEnum))]
        /* 0xA50 */ public TkTextureResource[] ConflictIcons;
        /* 0xC60 */ public TkTextureResource ConflictTechNotInstalledIcon;
        /* 0xCE4 */ public TkTextureResource WarpIcon;
        /* 0xD68 */ public TkTextureResource WarpErrorIcon;
        /* 0xDEC */ public TkTextureResource WarpTechNotInstalledIcon;
    }
}
