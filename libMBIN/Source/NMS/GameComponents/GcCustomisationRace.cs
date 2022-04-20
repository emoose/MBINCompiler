using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x38, GUID = 0xEE1F3F1FF4F8BF7A, NameHash = 0x231919D5AE192450)]
    public class GcCustomisationRace : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 DescriptorGroupOption;
        /* 0x10 */ public bool IsGek;
        /* 0x14 */ public float Scale;
        /* 0x18 */ public List<GcCustomisationGroup> CustomisationGroups;
        /* 0x28 */ public List<NMSString0x10> Presets;
    }
}
