using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x97BDE51DA4983EDA, NameHash = 0xCB6FA010D5725BB5)]
    public class GcModSettings : NMSTemplate
    {
        public List<GcModSettingsInfo> Data;
    }
}
