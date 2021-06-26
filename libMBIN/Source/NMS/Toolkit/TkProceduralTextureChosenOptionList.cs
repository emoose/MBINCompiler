using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x10, GUID = 0x38EFB67C33AE033D, NameHash = 0x2E2EA6E03BFB1DF8)]
    public class TkProceduralTextureChosenOptionList : NMSTemplate
    {
        public List<TkProceduralTextureChosenOptionSampler> Samplers; 
    }
}
