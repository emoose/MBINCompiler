using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x78E395C610366630)]
    public class TkProceduralTextureChosenOptionList : NMSTemplate
    {
        // list entries are aligned 0x10, not the default 0x8 todo: attribute for this!
        // this can be seen at 1402BF509 (1.0 gog), where the alignment argument is being set to 0x10
        public List<TkProceduralTextureChosenOptionSampler> Samplers; 
    }
}
