using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xF0, GUID = 0x0, NameHash = 0x0E7EC6E83CB496A6C)]
    public class GcCustomisationThrusterEffect : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string NodeName;
        /* 0x20 */ public bool SingleJet;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x21 */ public byte[] Padding21;
        [NMS(Size = 0x10)]
        /* 0x28 */ public string LinkedSpecialID;
        [NMS(Size = 0x20)]
        /* 0x38 */ public string Tip;
        /* 0x58 */ public TkTextureResource Trails;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xDC */ public byte[] PaddingDC;
        /* 0xE0 */ public List<GcCharacterJetpackEffect> Effects;
    }
}
