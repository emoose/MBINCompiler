using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA7934CF35CFA58B9, NameHash = 0xA2994124)]
    public class GcRewardSalvageShip : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xC, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x00 */ public NMSString0x10[] SpecificCustomisationSlotIDs;
        [NMS(Index = 0)]
        /* 0xC0 */ public bool RewardShipParts;
    }
}
