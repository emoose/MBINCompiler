using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x22F6AA8A2773219C)]
    public class GcSpawnAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Event;
    }
}
