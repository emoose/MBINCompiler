using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2452EC99FC0C771B, NameHash = 0x76B0722D154CFD89)]
    public class GcRewardPetAction : NMSTemplate
    {
        /* 0x00 */ public GcCreaturePetRewardActions PetAction;
        /* 0x08 */ public NMSString0x10 PlayerEmoteID;
        /* 0x18 */ public NMSString0x10 EffectID;
        /* 0x28 */ public NMSString0x10 SpecialHarvestID;
        /* 0x38 */ public int SpecialHarvestMul;
    }
}
