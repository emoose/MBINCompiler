using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1, GUID = 0x0000000000000000, NameHash = 0x9983F7BCE55D938D)]
    public class GcRewardSetWeaponSuppressed : NMSTemplate
    {
        public bool WeaponSuppressed;
    }
}
