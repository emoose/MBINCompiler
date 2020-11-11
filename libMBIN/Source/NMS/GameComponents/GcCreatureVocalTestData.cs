using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x38, GUID = 0xB5336C5F83DA397F, NameHash = 0x48BE998FD7F1C33A)]
    public class GcCreatureVocalTestData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string Genus;
        /* 0x30 */ public float Size;
        /* 0x34 */ public float Squawk;
    }
}
