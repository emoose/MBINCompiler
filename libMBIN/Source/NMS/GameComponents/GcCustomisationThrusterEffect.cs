using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xC8, GUID = 0x48A4414CC96082A0, NameHash = 0x0E7EC6E83CB496A6C)]
    public class GcCustomisationThrusterEffect : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string NodeName;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string LinkedSpecialID;
        /* 0x30 */ public TkTextureResource Trails;
        /* 0xB8 */ public List<GcCharacterJetpackEffect> Effects;
    }
}
