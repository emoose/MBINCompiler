namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE9CFABE1CF4D7A, NameHash = 0x61016ED971A59B9A)]
    public class GcMissionSequenceDiscover : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public bool PerPlanet;
        // size: 0x3
        public enum DiscoverTargetEnum : uint {
            Animal,
            Vegetable,
            Mineral,
        }
        /* 0x84 */ public DiscoverTargetEnum DiscoverTarget;
        /* 0x88 */ public int AmountMin;
        /* 0x8C */ public int AmountMax;
        /* 0x90 */ public bool TakeAmountFromSeasonalData;
        /* 0x91 */ public NMSString0x80 DebugText;
    }
}
