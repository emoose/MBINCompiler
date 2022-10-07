using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8F21833376B03851, NameHash = 0x5CEC8CD158852BFE)]
    public class GcRealityCraftingRecipeData : NMSTemplate
    {
        [NMS(Size = 0x3)]
        /* 0x00 */ public GcRealitySubstanceCraftingMix[] Inputs;
        /* 0x48 */ public NMSString0x10 OutputID;
    }
}
