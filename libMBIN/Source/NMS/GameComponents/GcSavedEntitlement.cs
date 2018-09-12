using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0DBC20526A13393C3)]
    public class GcSavedEntitlement : NMSTemplate // 0x100 bytes
    {
        [NMS(Size = 0x100)]
        public string EntitlementId;
    }
}
