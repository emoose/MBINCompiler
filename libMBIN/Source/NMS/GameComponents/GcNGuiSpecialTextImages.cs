using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x74258C82775950C, NameHash = 0x4A7B04831F4234B1)]
    public class GcNGuiSpecialTextImages : NMSTemplate
    {
        public List<GcNGuiSpecialTextImageData> SpecialImages;
    }
}