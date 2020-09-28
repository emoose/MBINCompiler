using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x58, GUID = 0xF0E26C56F25263E1, NameHash = 0x6BD985F678734B62)]
    public class TkMaterialSketchData : NMSTemplate
    {
        /* 0x00 */ public List<TkMaterialSketchNode> SketchNodes;
        /* 0x10 */ public List<TkMaterialSketchLink> SketchLinks;
        /* 0x20 */ public List<NMSString0x20> SketchFlags;
        /* 0x30 */ public List<TkMaterialSketchComment> SketchCmts;
        /* 0x40 */ public float ScrollX;
        /* 0x44 */ public float ScrollY;
        /* 0x48 */ public float Zoom;
        /* 0x4C */ public int OutputX;
        /* 0x50 */ public int OutputY;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x54 */ public byte[] EndPadding;
    }
}