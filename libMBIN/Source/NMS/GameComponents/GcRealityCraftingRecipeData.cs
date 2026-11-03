using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95DE9F8520FBE38D, NameHash = 0xBEC65145)]
    public class GcRealityCraftingRecipeData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3)]
        /* 0x00 */ public GcRealitySubstanceCraftingMix[] Inputs;
        [NMS(Index = 1)]
        /* 0x48 */ public NMSString0x10 OutputID;
    }
}
