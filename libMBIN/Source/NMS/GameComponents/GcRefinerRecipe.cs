using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0xB724C69807198B4F)]
    public class GcRefinerRecipe : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Name;
        /* 0x20 */ public float TimeToMake;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] Padding84;
        /* 0x28 */ public GcRefinerRecipeElement Result;
        /* 0x40 */ public List<GcRefinerRecipeElement> Ingredients;
    }
}
