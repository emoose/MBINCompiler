using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9A1039C01ED519C)]
    public class GcSpawnComponentOption : NMSTemplate // 0x2C8 bytes
    {
        [NMS(Size = 0x10)]
        public string Name;
        public GcSeed Seed;
        public GcResourceElement SpecificModel;
    }
}
