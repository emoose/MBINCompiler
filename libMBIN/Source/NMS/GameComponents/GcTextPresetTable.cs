using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD1B812B3A299F71, NameHash = 0x6567927C2DD8F89F)]
    public class GcTextPresetTable : NMSTemplate
    {
        /* 0x0 */ public List<GcTextPreset> Table;
    }
}
