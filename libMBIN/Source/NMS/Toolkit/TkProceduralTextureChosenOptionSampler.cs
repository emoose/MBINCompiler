using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x10, GUID = 0x23FA5B039B755137, NameHash = 0x949DC1DF3C62FC0A)]
    public class TkProceduralTextureChosenOptionSampler : NMSTemplate
    {
        /* 0x0 */ public List<TkProceduralTextureChosenOption> Options;
    }
}
