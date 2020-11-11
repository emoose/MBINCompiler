using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x180, GUID = 0x6BF046DD9D048692, NameHash = 0x73308053CF12ECFF)]
    public class GcHUDMarkerData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Icon;
        [NMS(Size = 0x80)]
        public string IconBehind;
        [NMS(Size = 0x80)]
        public string Distance;
    }
}
