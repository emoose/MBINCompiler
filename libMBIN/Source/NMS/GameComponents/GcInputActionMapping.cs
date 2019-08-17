using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD78F3098C042D8F8, SubGUID = 0x83F86B65AEFACBEC)]
    public class GcInputActionMapping : NMSTemplate
    {
        public int RemappedKey = -1;
        public int RemappedPad = -1;
    }
}
