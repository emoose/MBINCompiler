using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0x40C095D3E7698705)]
    public class GcExternalObjectList : NMSTemplate
    {
        public GcEnvironmentSpawnData Objects;
    }
}
