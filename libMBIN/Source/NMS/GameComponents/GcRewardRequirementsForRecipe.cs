using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x0000000000000000, NameHash = 0x0EC60D3F951991D7)]
    public class GcRewardRequirementsForRecipe : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string RecipeID;
        public bool RewardInCreative;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
