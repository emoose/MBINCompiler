using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0xEF8E89F8106CED17, NameHash = 0x29C73977774C3241)]
    public class GcStateTimeEvent : NMSTemplate
    {
        public float Seconds;
        public float RandomSeconds;
    }
}
