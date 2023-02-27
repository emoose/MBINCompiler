using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74F47B52F687DFAA, NameHash = 0x9ED3D0A38623AF53)]
    public class GcPetAccessoryTable : NMSTemplate
    {
        [NMS(Size = 0x1B, EnumType = typeof(GcPetAccessoryType.PetAccessoryEnum))]
        /* 0x000 */ public GcPetAccessoryInfo[] Accessories;
        /* 0x360 */ public List<GcPetAccessoryGroup> AccessoryGroups;
    }
}
