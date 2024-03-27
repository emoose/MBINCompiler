using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9BC266A4CB498F03, NameHash = 0xB0A39161047DD10D)]
    public class GcHUDStartupTable : NMSTemplate
    {
        /* 0x00 */ public float FadeInFlashTime;
        /* 0x04 */ public float LookSpeed;
        /* 0x08 */ public float StartHoldTime;
        /* 0x0C */ public float ButtonFlashRate;
        /* 0x10 */ public float ButtonFlashAlpha;
        /* 0x14 */ public float BackgroundAlpha;
        // size: 0xD
        public enum HUDStartupEnum {
            WaitingForInit,
            Startup,
            Booting,
            LifeSupport,
            Shield,
            ShieldEffect,
            Scanner,
            Jetpack,
            Weapon,
            Finishing,
            DiscoverPlanet,
            Done,
            Inactive,
        }
        [NMS(Size = 0xD, EnumType = typeof(HUDStartupEnum))]
        /* 0x18 */ public GcHUDStartup[] HUDStartup;
    }
}
