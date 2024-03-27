namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC36EF22C8FB1973C, NameHash = 0x368D06565D9CC1)]
    public class GcMissionSequenceDiscoverOnPlanet : NMSTemplate
    {
        /* 0x00 */ public float PercentToDiscover;
        /* 0x04 */ public NMSString0x80 Message;
        // size: 0x3
        public enum DiscoverTargetOnThisPlanetEnum : uint {
            Animal,
            Vegetable,
            Mineral,
        }
        /* 0x84 */ public DiscoverTargetOnThisPlanetEnum DiscoverTargetOnThisPlanet;
        /* 0x88 */ public NMSString0x80 DebugText;
    }
}
