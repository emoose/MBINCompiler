using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x200, GUID = 0x2C04CD0BD6534FA0, NameHash = 0xBEE79269D7359654)]
    public class TkProceduralTextureList : NMSTemplate
    {
        [NMS(Size = 0x8)]
        public TkProceduralTextureLayer[] Layers;
    }
}
