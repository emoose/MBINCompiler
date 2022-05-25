using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x5637F3002418C38E, NameHash = 0xD0AAAD197E826825)]
    public class GcRewardSpecificProductRecipe : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public bool Slient;
        /* 0x11 */ public bool HideInSeasonRewards;
    }
}