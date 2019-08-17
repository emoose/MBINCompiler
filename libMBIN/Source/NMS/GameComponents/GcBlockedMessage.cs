using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD616F53EB85ECEEC, SubGUID = 0xD51346A323488A3E)]
    public class GcBlockedMessage : NMSTemplate        // size: 0x80
    {
        [NMS(Size = 0x80)]
        public string MessageID;
    }
}
