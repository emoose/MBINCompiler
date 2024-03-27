using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x429BAEC272104F10, NameHash = 0xC127D8D3D9D7F5D8)]
    public class GcRewardSalvageShip : NMSTemplate
    {
        /* 0x0 */ public bool RewardShipParts;
        [NMS(Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x8 */ public NMSString0x10[] SpecificCustomisationSlotIDs;
    }
}
