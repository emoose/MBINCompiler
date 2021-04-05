using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x28, GUID = 0x0000000000000000, NameHash = 0xE65D6D9E5CB7E8A3)]
    public class TkMaterialShaderMillConnect : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Name;
        /* 0x20 */ public int Count;
        /* 0x24 */ public bool Expanded;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x25 */ public byte[] EndPadding;
    }
}
