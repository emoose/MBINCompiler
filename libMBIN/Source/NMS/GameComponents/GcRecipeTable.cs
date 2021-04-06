using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xF736FF0677339B90, NameHash = 0xB05B3758665D56DE)]
    public class GcRecipeTable : NMSTemplate
    {
        public List<GcRefinerRecipe> Table;
    }
}