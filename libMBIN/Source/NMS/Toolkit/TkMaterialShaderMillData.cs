using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD617F7F352D5E186, NameHash = 0xE5F4152C8F8FC861)]
    public class TkMaterialShaderMillData : NMSTemplate
    {
        /* 0x000 */ public List<TkMaterialShaderMillNode> ShaderMillNodes;
        /* 0x010 */ public List<TkMaterialShaderMillLink> ShaderMillLinks;
        /* 0x020 */ public List<TkMaterialShaderMillFlag> ShaderMillFlags;
        /* 0x030 */ public List<TkMaterialShaderMillComment> ShaderMillCmts;
        /* 0x040 */ public NMSString0x40 Name;
        /* 0x080 */ public NMSString0x80 Filename;
        /* 0x100 */ public NMSString0x200 Description;
        /* 0x300 */ public float ScrollX;
        /* 0x304 */ public float ScrollY;
        /* 0x308 */ public float Zoom;
        /* 0x30C */ public int OutputX;
        /* 0x310 */ public int OutputY;
    }
}
