using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, GUID = 0xFB6953103434EDD8, NameHash = 0xA6A8B93C2B1FA9F0)]
    public class GcAtlasDiscoveryMetadata : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string CustomName;
    }
}