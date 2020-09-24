using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x541B622CB34F0EBB, NameHash = 0x3DFFD10C388635E7)]
    public class GcCreatureTagAndRarity : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Tag;
        public GcCreatureRarity RarityOverride;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
