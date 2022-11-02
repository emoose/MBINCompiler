using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9F1FDB11C4517E8C, NameHash = 0x2E2EA6E03BFB1DF8)]
    public class TkProceduralTextureChosenOptionList : NMSTemplate
    {
        /* 0x0 */ public List<TkProceduralTextureChosenOptionSampler> Samplers;
    }
}
