using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x10, GUID = 0x8578DEEF68E7D98C, NameHash = 0x949DC1DF3C62FC0A)]
    public class TkProceduralTextureChosenOptionSampler : NMSTemplate
    {
        public List<TkProceduralTextureChosenOption> Options;
    }
}
