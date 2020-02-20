using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xE40, GUID = 0xBA15624EC65A5DC8, NameHash = 0x22BD6A8E5AD4C4CB)]
    public class GcNPCPropTable : NMSTemplate
    {
        [NMS(Size = 0xC, EnumType = typeof(GcNPCPropTypes.NPCPropEnum))]
        public GcNPCPropInfo[] Props;
    }
}
