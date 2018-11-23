using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0xABF17392D4C2F9F4)]
    public class GcBaseBuildingEntryLinkGridData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        public enum ConnectionTypeEnum { Many, Single }
        /* 0x10 */ public ConnectionTypeEnum ConnectionType;
        /* 0x14 */ public int LinkMask;
        /* 0x18 */ public float ConnectionDistance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1C */ public byte[] Padding1C;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string ConnectionPart;
        /* 0x30 */ public int Rate;
        /* 0x34 */ public int Storage;
    }
}
