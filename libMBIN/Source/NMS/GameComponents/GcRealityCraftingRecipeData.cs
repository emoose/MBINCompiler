using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x90B4295D3193C0CF, NameHash = 0x5CEC8CD158852BFE)]
    public class GcRealityCraftingRecipeData : NMSTemplate
    {
        [NMS(Size = 0x3)]
        /* 0x00 */ public GcRealitySubstanceCraftingMix[] Inputs;
        /* 0x48 */ public NMSString0x10 OutputID;
    }
}
