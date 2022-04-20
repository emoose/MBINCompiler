using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x10, GUID = 0xCEA3C4BE22DA3BCE, NameHash = 0x2E2EA6E03BFB1DF8)]
    public class TkProceduralTextureChosenOptionList : NMSTemplate
    {
        /* 0x0 */ public List<TkProceduralTextureChosenOptionSampler> Samplers;
    }
}
