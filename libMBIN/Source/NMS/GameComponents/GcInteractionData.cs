using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3CFD2D492048F389)]
    public class GcInteractionData : NMSTemplate // 0x20 bytes
    {
        public ulong GalacticAddress;
        public ulong Value;
        public Vector4f Position;
    }
}
