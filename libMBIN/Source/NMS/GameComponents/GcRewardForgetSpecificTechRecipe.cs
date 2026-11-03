using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD80B43768E91C5CD, NameHash = 0xC8C245D3)]
    public class GcRewardForgetSpecificTechRecipe : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x10> TechList;
    }
}
