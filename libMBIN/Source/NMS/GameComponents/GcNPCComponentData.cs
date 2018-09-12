using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x0E1870C528F718DCE)]
    public class GcNPCComponentData : NMSTemplate
    {
        public GcAlienRace AlienRace;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x10)]
        public string HologramEffect;
        public bool IsOldStyleNPC;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
