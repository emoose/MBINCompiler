using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F6B480612148B69, NameHash = 0xB05B3758665D56DE)]
    public class GcRecipeTable : NMSTemplate
    {
        /* 0x0 */ public List<GcRefinerRecipe> Table;
    }
}
